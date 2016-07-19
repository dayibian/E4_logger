using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;

namespace EmpaticaBLEClient
{
    public static class AsynchronousClient
    {
        // Data arrays used for chart display
        private const int sampleSize = 200;
        public static double[] gsr = new double[sampleSize];
        public static double[] bvp = new double[sampleSize];
        public static double[] tmp = new double[sampleSize];
        //private static string filename = "\test.txt";
        private static StreamWriter physioData;
        private static StreamWriter gsrData;
        private static StreamWriter bvpData;
        private static StreamWriter tmpData;



        // The port number for the remote device.
        private const string ServerAddress = "127.0.0.1";
        private const int ServerPort = 100;
        // Create a TCP/IP socket.
        private static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // ManualResetEvent instances signal completion.
        private static readonly ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static readonly ManualResetEvent SendDone = new ManualResetEvent(false);
        private static readonly ManualResetEvent ReceiveDone = new ManualResetEvent(false);

        // The response from the remote device.
        private static String _response = String.Empty;

        public static string ConnectToServer()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                var ipHostInfo = new IPHostEntry { AddressList = new[] { IPAddress.Parse(ServerAddress) } };
                var ipAddress = ipHostInfo.AddressList[0];
                var remoteEp = new IPEndPoint(ipAddress, ServerPort);

                // Create a TCP/IP socket.
                //var client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                client.BeginConnect(remoteEp, (ConnectCallback), client);
                ConnectDone.WaitOne();
                return "Connected to server.";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static string ConnectToDevice()
        {
            string msg = "device_connect 6C04BC";
            CommunicateWithServer(client, msg);
            return _response;
        }

        public static void GetSignal()
        {
            physioData = new StreamWriter(@"D:\Documents\AffectiveTouchProject\E4_DataLogger\E4_DataLogger\data\physioData.txt");
            gsrData = new StreamWriter(@"D:\Documents\AffectiveTouchProject\E4_DataLogger\E4_DataLogger\data\gsr.txt");
            bvpData = new StreamWriter(@"D:\Documents\AffectiveTouchProject\E4_DataLogger\E4_DataLogger\data\bvp.txt");
            tmpData = new StreamWriter(@"D:\Documents\AffectiveTouchProject\E4_DataLogger\E4_DataLogger\data\tmp.txt");

            string msg = "device_subscribe gsr ON";
            CommunicateWithServer(client, msg);
            Thread.Sleep(500);
            msg = "device_subscribe bvp ON";
            CommunicateWithServer(client, msg);
            Thread.Sleep(500);
            msg = "device_subscribe tmp ON";
            CommunicateWithServer(client, msg);
        }

        public static void DisconnectFromServer()
        {
            string msg = "device_disconnect";
            CommunicateWithServer(client, msg);
            physioData.Close();
            gsrData.Close();
            bvpData.Close();
            tmpData.Close();
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                var client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint);

                // Signal that the connection has been made.
                ConnectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                var state = new StateObject { WorkSocket = client };

                // Begin receiving the data from the remote device.
                client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, ReceiveCallback, state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                var state = (StateObject)ar.AsyncState;
                var client = state.WorkSocket;

                // Read data from the remote device.
                var bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.Sb.Append(Encoding.ASCII.GetString(state.Buffer, 0, bytesRead));
                    _response = state.Sb.ToString();

                    HandleResponseFromEmpaticaBLEServer(_response);

                    state.Sb.Clear();

                    ReceiveDone.Set();

                    // Get the rest of the data.
                    client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, ReceiveCallback, state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.Sb.Length > 1)
                    {
                        _response = state.Sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    ReceiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, string data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, 0, SendCallback, client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                var client = (Socket)ar.AsyncState;
                // Complete sending the data to the remote device.
                client.EndSend(ar);
                // Signal that all bytes have been sent.
                SendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void HandleResponseFromEmpaticaBLEServer(string response)
        {
            string[] results = response.Split(new string[] { Environment.NewLine, " " }, 
                StringSplitOptions.None);
            if(results[0] != "R")
            {
                physioData.Write(response);
                if(results[0] == "E4_Gsr")
                {
                    shiftData(gsr, Convert.ToDouble(results[2]));
                    gsrData.Write(response);
                }
                else if(results[0] == "E4_Temperature")
                {
                    shiftData(tmp, Convert.ToDouble(results[2]));
                    tmpData.Write(response);
                }
                else if(results[0] == "E4_Bvp")
                {
                    shiftData(bvp, Convert.ToDouble(results[2]));
                    bvpData.Write(response);
                }
            }
        }

        //
        // Utility to shift a double value into an array
        //
        private static void shiftData(double[] data, double newValue)
        {
            for (int i = 1; i < data.Length; ++i)
                data[i - 1] = data[i];
            data[data.Length - 1] = newValue;
        }

        private static void CommunicateWithServer(Socket client, string msg)
        {
            Send(client, msg + Environment.NewLine);
            SendDone.WaitOne();
            Receive(client);
            ReceiveDone.WaitOne();
        }
    }
}