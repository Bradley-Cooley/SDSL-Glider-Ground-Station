namespace SDSL.GliderGroundStation.View
{
    partial class GroundStationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroundStationForm));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.missionInfoGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.satelliteCountLabel = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.packetCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.missionTimeLabel = new System.Windows.Forms.Label();
            this.imageGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.packetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectButton = new System.Windows.Forms.Button();
            this.missionStartButton = new System.Windows.Forms.Button();
            this.releaseButton = new System.Windows.Forms.Button();
            this.audioButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.takePhotoButton = new System.Windows.Forms.Button();
            this.servoAngleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.angleTrackbar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.altitudeGPSLabel = new System.Windows.Forms.Label();
            this.airspeedLabel = new System.Windows.Forms.Label();
            this.speedGPSLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.groundStationFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutMain.SuspendLayout();
            this.missionInfoGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.imageGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetsBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackbar)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groundStationFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutMain.Controls.Add(this.missionInfoGroup, 0, 0);
            this.tableLayoutMain.Controls.Add(this.imageGroup, 1, 0);
            this.tableLayoutMain.Controls.Add(this.chart1, 2, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1258, 738);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // missionInfoGroup
            // 
            this.missionInfoGroup.Controls.Add(this.tableLayoutPanel1);
            this.missionInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missionInfoGroup.Location = new System.Drawing.Point(3, 3);
            this.missionInfoGroup.Name = "missionInfoGroup";
            this.tableLayoutMain.SetRowSpan(this.missionInfoGroup, 2);
            this.missionInfoGroup.Size = new System.Drawing.Size(346, 732);
            this.missionInfoGroup.TabIndex = 0;
            this.missionInfoGroup.TabStop = false;
            this.missionInfoGroup.Text = "Mission Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pressureLabel, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.speedGPSLabel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.airspeedLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.altitudeGPSLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.altitudeLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.longitudeLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.latitudeLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.satelliteCountLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.voltageLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.packetCountLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.missionTimeLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 707);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 62);
            this.label8.TabIndex = 16;
            this.label8.Text = "Longitude:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLabel.Location = new System.Drawing.Point(174, 322);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(161, 62);
            this.longitudeLabel.TabIndex = 15;
            this.longitudeLabel.Text = "0.0";
            this.longitudeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLabel.Location = new System.Drawing.Point(174, 258);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(161, 62);
            this.latitudeLabel.TabIndex = 14;
            this.latitudeLabel.Text = "0.0";
            this.latitudeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 62);
            this.label2.TabIndex = 13;
            this.label2.Text = "Latitude:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // satelliteCountLabel
            // 
            this.satelliteCountLabel.AutoSize = true;
            this.satelliteCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satelliteCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satelliteCountLabel.Location = new System.Drawing.Point(174, 194);
            this.satelliteCountLabel.Name = "satelliteCountLabel";
            this.satelliteCountLabel.Size = new System.Drawing.Size(161, 62);
            this.satelliteCountLabel.TabIndex = 12;
            this.satelliteCountLabel.Text = "0";
            this.satelliteCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voltageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.Location = new System.Drawing.Point(174, 130);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(161, 62);
            this.voltageLabel.TabIndex = 11;
            this.voltageLabel.Text = "0 V";
            this.voltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // packetCountLabel
            // 
            this.packetCountLabel.AutoSize = true;
            this.packetCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packetCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetCountLabel.Location = new System.Drawing.Point(174, 66);
            this.packetCountLabel.Name = "packetCountLabel";
            this.packetCountLabel.Size = new System.Drawing.Size(161, 62);
            this.packetCountLabel.TabIndex = 10;
            this.packetCountLabel.Text = "0";
            this.packetCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 62);
            this.label7.TabIndex = 9;
            this.label7.Text = "GPS Satellites:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 62);
            this.label6.TabIndex = 8;
            this.label6.Text = "Voltage:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 62);
            this.label5.TabIndex = 7;
            this.label5.Text = "Packet Count:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mission Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // missionTimeLabel
            // 
            this.missionTimeLabel.AutoSize = true;
            this.missionTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missionTimeLabel.Location = new System.Drawing.Point(174, 2);
            this.missionTimeLabel.Name = "missionTimeLabel";
            this.missionTimeLabel.Size = new System.Drawing.Size(161, 62);
            this.missionTimeLabel.TabIndex = 2;
            this.missionTimeLabel.Text = "00:00:00";
            this.missionTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageGroup
            // 
            this.imageGroup.Controls.Add(this.tableLayoutPanel2);
            this.imageGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGroup.Location = new System.Drawing.Point(355, 3);
            this.imageGroup.Name = "imageGroup";
            this.tableLayoutMain.SetRowSpan(this.imageGroup, 2);
            this.imageGroup.Size = new System.Drawing.Size(446, 732);
            this.imageGroup.TabIndex = 1;
            this.imageGroup.TabStop = false;
            this.imageGroup.Text = "Imaging";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 707);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Seconds";
            chartArea1.AxisY.Title = "Altitude (m)";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartAreaAltitude";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 50F;
            chartArea1.Position.Width = 50F;
            chartArea2.AxisX.Title = "Seconds";
            chartArea2.AxisY.Title = "Speed (m/s)";
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartAreaSpeed";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 50F;
            chartArea2.Position.Width = 50F;
            chartArea2.Position.X = 50F;
            chartArea3.AxisX.Title = "Seconds";
            chartArea3.AxisY.Title = "Pressure (bar)";
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartAreaPressure";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 50F;
            chartArea3.Position.Width = 50F;
            chartArea3.Position.Y = 50F;
            chartArea4.AxisX.Title = "Seconds";
            chartArea4.AxisY.Title = "Temperature (C)";
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartAreaTemperature";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 50F;
            chartArea4.Position.Width = 50F;
            chartArea4.Position.X = 50F;
            chartArea4.Position.Y = 50F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(807, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.tableLayoutMain.SetRowSpan(this.chart1, 2);
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartAreaAltitude";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsXValueIndexed = true;
            series1.Name = "SeriesAltitudeAltimeter";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartAreaAltitude";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.IsXValueIndexed = true;
            series2.Name = "SeriesAltitudeGPS";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartAreaSpeed";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.IsXValueIndexed = true;
            series3.Name = "SeriesSpeedPitot";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartAreaSpeed";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsXValueIndexed = true;
            series4.Name = "SeriesSpeedGPS";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartAreaPressure";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.IsXValueIndexed = true;
            series5.Name = "SeriesPressure";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartAreaTemperature";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.IsXValueIndexed = true;
            series6.Name = "SeriesTemperature";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(448, 732);
            this.chart1.TabIndex = 3;
            // 
            // packetsBindingSource
            // 
            this.packetsBindingSource.DataMember = "Packets";
            this.packetsBindingSource.DataSource = this.groundStationFormBindingSource;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectButton.Location = new System.Drawing.Point(3, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(211, 49);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // missionStartButton
            // 
            this.missionStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missionStartButton.Location = new System.Drawing.Point(220, 3);
            this.missionStartButton.Name = "missionStartButton";
            this.missionStartButton.Size = new System.Drawing.Size(211, 49);
            this.missionStartButton.TabIndex = 6;
            this.missionStartButton.Text = "Mission Start";
            this.missionStartButton.UseVisualStyleBackColor = true;
            this.missionStartButton.Click += new System.EventHandler(this.missionStartButton_Click);
            // 
            // releaseButton
            // 
            this.releaseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releaseButton.Location = new System.Drawing.Point(3, 58);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(211, 49);
            this.releaseButton.TabIndex = 7;
            this.releaseButton.Text = "Release Override";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // audioButton
            // 
            this.audioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioButton.Location = new System.Drawing.Point(220, 58);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(211, 49);
            this.audioButton.TabIndex = 8;
            this.audioButton.Text = "Audio Override";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(434, 347);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.takePhotoButton);
            this.panel1.Controls.Add(this.servoAngleTextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.angleTrackbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 225);
            this.panel1.TabIndex = 3;
            // 
            // takePhotoButton
            // 
            this.takePhotoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.takePhotoButton.Location = new System.Drawing.Point(83, 108);
            this.takePhotoButton.Name = "takePhotoButton";
            this.takePhotoButton.Size = new System.Drawing.Size(268, 78);
            this.takePhotoButton.TabIndex = 4;
            this.takePhotoButton.Text = "Commit Angle \r\nand \r\nTake Photo";
            this.takePhotoButton.UseVisualStyleBackColor = true;
            this.takePhotoButton.Click += new System.EventHandler(this.takePhotoButton_Click);
            // 
            // servoAngleTextBox
            // 
            this.servoAngleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.servoAngleTextBox.Location = new System.Drawing.Point(167, 7);
            this.servoAngleTextBox.Name = "servoAngleTextBox";
            this.servoAngleTextBox.Size = new System.Drawing.Size(100, 26);
            this.servoAngleTextBox.TabIndex = 3;
            this.servoAngleTextBox.Text = "0";
            this.servoAngleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Right";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Left";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // angleTrackbar
            // 
            this.angleTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.angleTrackbar.LargeChange = 15;
            this.angleTrackbar.Location = new System.Drawing.Point(3, 33);
            this.angleTrackbar.Maximum = 90;
            this.angleTrackbar.Minimum = -90;
            this.angleTrackbar.Name = "angleTrackbar";
            this.angleTrackbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.angleTrackbar.Size = new System.Drawing.Size(428, 69);
            this.angleTrackbar.SmallChange = 10;
            this.angleTrackbar.TabIndex = 0;
            this.angleTrackbar.TickFrequency = 5;
            this.angleTrackbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.audioButton, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.missionStartButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.releaseButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.connectButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(434, 110);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 62);
            this.label9.TabIndex = 17;
            this.label9.Text = "Altitude:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 62);
            this.label10.TabIndex = 18;
            this.label10.Text = "GPS Altitude:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 62);
            this.label13.TabIndex = 19;
            this.label13.Text = "Airspeed:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 62);
            this.label14.TabIndex = 20;
            this.label14.Text = "GPS Speed:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 642);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 63);
            this.label15.TabIndex = 21;
            this.label15.Text = "Pressure:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeLabel.Location = new System.Drawing.Point(174, 386);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(161, 62);
            this.altitudeLabel.TabIndex = 22;
            this.altitudeLabel.Text = "0.0";
            this.altitudeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // altitudeGPSLabel
            // 
            this.altitudeGPSLabel.AutoSize = true;
            this.altitudeGPSLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altitudeGPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeGPSLabel.Location = new System.Drawing.Point(174, 450);
            this.altitudeGPSLabel.Name = "altitudeGPSLabel";
            this.altitudeGPSLabel.Size = new System.Drawing.Size(161, 62);
            this.altitudeGPSLabel.TabIndex = 23;
            this.altitudeGPSLabel.Text = "0.0";
            this.altitudeGPSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airspeedLabel
            // 
            this.airspeedLabel.AutoSize = true;
            this.airspeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airspeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airspeedLabel.Location = new System.Drawing.Point(174, 514);
            this.airspeedLabel.Name = "airspeedLabel";
            this.airspeedLabel.Size = new System.Drawing.Size(161, 62);
            this.airspeedLabel.TabIndex = 24;
            this.airspeedLabel.Text = "0.0";
            this.airspeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // speedGPSLabel
            // 
            this.speedGPSLabel.AutoSize = true;
            this.speedGPSLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedGPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGPSLabel.Location = new System.Drawing.Point(174, 578);
            this.speedGPSLabel.Name = "speedGPSLabel";
            this.speedGPSLabel.Size = new System.Drawing.Size(161, 62);
            this.speedGPSLabel.TabIndex = 25;
            this.speedGPSLabel.Text = "0.0";
            this.speedGPSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.Location = new System.Drawing.Point(174, 642);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(161, 63);
            this.pressureLabel.TabIndex = 26;
            this.pressureLabel.Text = "0.0";
            this.pressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groundStationFormBindingSource
            // 
            this.groundStationFormBindingSource.DataSource = typeof(SDSL.GliderGroundStation.View.GroundStationForm);
            // 
            // GroundStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1258, 738);
            this.Controls.Add(this.tableLayoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "GroundStationForm";
            this.Text = "SDSL Glider Ground Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GroundStationForm_Load);
            this.tableLayoutMain.ResumeLayout(false);
            this.missionInfoGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.imageGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetsBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackbar)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groundStationFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.GroupBox missionInfoGroup;
        private System.Windows.Forms.GroupBox imageGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label missionTimeLabel;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.Label packetCountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource groundStationFormBindingSource;
        private System.Windows.Forms.BindingSource packetsBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label satelliteCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button audioButton;
        private System.Windows.Forms.Button releaseButton;
        private System.Windows.Forms.Button missionStartButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label speedGPSLabel;
        private System.Windows.Forms.Label airspeedLabel;
        private System.Windows.Forms.Label altitudeGPSLabel;
        private System.Windows.Forms.Label altitudeLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button takePhotoButton;
        private System.Windows.Forms.TextBox servoAngleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar angleTrackbar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

