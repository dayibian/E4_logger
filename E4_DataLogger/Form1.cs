using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EmpaticaBLEClient;

namespace E4_DataLogger
{
    public partial class PhysioRealTimeDisplay : Form
    {
        public PhysioRealTimeDisplay()
        {
            InitializeComponent();
        }

        private void PhysioRealTimeDisplay_Load(object sender, EventArgs e)
        {
            chartUpdateTimer.Interval = 50;
        }

        private void serverConnectButton_Click(object sender, EventArgs e)
        {
            messageDisplay.Text = AsynchronousClient.ConnectToServer();
        }

        private void deviceConnectButton_Click(object sender, EventArgs e)
        {
            messageDisplay.Text = AsynchronousClient.ConnectToDevice();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            AsynchronousClient.GetSignal();
            chartUpdateTimer.Start();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            AsynchronousClient.DisconnectFromServer();
        }

        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            gsrChart.Series["GSR"].Points.Clear();
            ppgChart.Series["PPG"].Points.Clear();
            sktChart.Series["SKT"].Points.Clear();

            gsrChart.Series["GSR"].Points.DataBindY(AsynchronousClient.gsr);
            ppgChart.Series["PPG"].Points.DataBindY(AsynchronousClient.bvp);
            sktChart.Series["SKT"].Points.DataBindY(AsynchronousClient.tmp);
        }
    }
}
