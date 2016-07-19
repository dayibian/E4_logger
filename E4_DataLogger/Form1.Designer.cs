namespace E4_DataLogger
{
    partial class PhysioRealTimeDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysioRealTimeDisplay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gsrChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ppgChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sktChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.serverConnectButton = new System.Windows.Forms.Button();
            this.deviceConnectButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.messageDisplay = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppgChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sktChart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gsrChart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ppgChart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sktChart, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(191, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(747, 423);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gsrChart
            // 
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.gsrChart.ChartAreas.Add(chartArea1);
            this.gsrChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.gsrChart.Legends.Add(legend1);
            this.gsrChart.Location = new System.Drawing.Point(3, 3);
            this.gsrChart.Name = "gsrChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "GSR";
            this.gsrChart.Series.Add(series1);
            this.gsrChart.Size = new System.Drawing.Size(741, 133);
            this.gsrChart.TabIndex = 0;
            this.gsrChart.Text = "chart1";
            // 
            // ppgChart
            // 
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.ppgChart.ChartAreas.Add(chartArea2);
            this.ppgChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ppgChart.Legends.Add(legend2);
            this.ppgChart.Location = new System.Drawing.Point(3, 142);
            this.ppgChart.Name = "ppgChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "PPG";
            this.ppgChart.Series.Add(series2);
            this.ppgChart.Size = new System.Drawing.Size(741, 133);
            this.ppgChart.TabIndex = 1;
            this.ppgChart.Text = "chart2";
            // 
            // sktChart
            // 
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.sktChart.ChartAreas.Add(chartArea3);
            this.sktChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.sktChart.Legends.Add(legend3);
            this.sktChart.Location = new System.Drawing.Point(3, 281);
            this.sktChart.Name = "sktChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "SKT";
            this.sktChart.Series.Add(series3);
            this.sktChart.Size = new System.Drawing.Size(741, 139);
            this.sktChart.TabIndex = 2;
            this.sktChart.Text = "chart3";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.serverConnectButton);
            this.flowLayoutPanel1.Controls.Add(this.deviceConnectButton);
            this.flowLayoutPanel1.Controls.Add(this.displayButton);
            this.flowLayoutPanel1.Controls.Add(this.disconnectButton);
            this.flowLayoutPanel1.Controls.Add(this.messageDisplay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 429);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // serverConnectButton
            // 
            this.serverConnectButton.Location = new System.Drawing.Point(45, 45);
            this.serverConnectButton.Margin = new System.Windows.Forms.Padding(20);
            this.serverConnectButton.Name = "serverConnectButton";
            this.serverConnectButton.Size = new System.Drawing.Size(109, 23);
            this.serverConnectButton.TabIndex = 0;
            this.serverConnectButton.Text = "Connect to server";
            this.serverConnectButton.UseVisualStyleBackColor = true;
            this.serverConnectButton.Click += new System.EventHandler(this.serverConnectButton_Click);
            // 
            // deviceConnectButton
            // 
            this.deviceConnectButton.Location = new System.Drawing.Point(45, 108);
            this.deviceConnectButton.Margin = new System.Windows.Forms.Padding(20);
            this.deviceConnectButton.Name = "deviceConnectButton";
            this.deviceConnectButton.Size = new System.Drawing.Size(109, 23);
            this.deviceConnectButton.TabIndex = 2;
            this.deviceConnectButton.Text = "Connect to device";
            this.deviceConnectButton.UseVisualStyleBackColor = true;
            this.deviceConnectButton.Click += new System.EventHandler(this.deviceConnectButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(45, 171);
            this.displayButton.Margin = new System.Windows.Forms.Padding(20);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(109, 23);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(45, 234);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(20);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(109, 23);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconncet";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // messageDisplay
            // 
            this.messageDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.messageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageDisplay.ForeColor = System.Drawing.Color.Black;
            this.messageDisplay.Location = new System.Drawing.Point(30, 297);
            this.messageDisplay.Margin = new System.Windows.Forms.Padding(5, 20, 20, 20);
            this.messageDisplay.Name = "messageDisplay";
            this.messageDisplay.Size = new System.Drawing.Size(139, 13);
            this.messageDisplay.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(935, 41);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "E4 Wrist Band Physiological Signal Logger";
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // PhysioRealTimeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhysioRealTimeDisplay";
            this.Text = "E4 Physiology Application";
            this.Load += new System.EventHandler(this.PhysioRealTimeDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gsrChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppgChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sktChart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart gsrChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ppgChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sktChart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button serverConnectButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox messageDisplay;
        private System.Windows.Forms.Timer chartUpdateTimer;
        private System.Windows.Forms.Button deviceConnectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

