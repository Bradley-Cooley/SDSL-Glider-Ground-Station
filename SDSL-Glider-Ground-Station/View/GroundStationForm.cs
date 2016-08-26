using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SDSL.GliderGroundStation.View
{
    public partial class GroundStationForm : Form, IGroundStationView
    {
        private bool countMissionTime;

        public GroundStationForm()
        {
            InitializeComponent();

            countMissionTime = false;
        }

        private int MissionStage
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private int MissionTime
        {
            get { return Convert.ToInt32(TimeSpan.Parse(this.missionTimeLabel.Text).TotalSeconds); }
            set { this.missionTimeLabel.Text = TimeSpan.FromSeconds(Convert.ToDouble(value)).ToString(); }
        }

        private int PacketCount
        {
            get { return Convert.ToInt32(this.packetCountLabel.Text); }
            set { this.packetCountLabel.Text = value.ToString(); }
        }

        public List<Model.TelemetryPacket> Packets
        {
            get;

            set;
        }

        public Presenter.GroundStationPresenter Presenter
        { private get; set; }

        private int SatelliteCount
        {
            get { return Convert.ToInt32(this.satelliteCountLabel.Text); }
            set { this.satelliteCountLabel.Text = value.ToString(); }
        }

        public int ServoAngle
        {
            get { return Convert.ToInt32(this.servoAngleTextBox.Text); }
            set { this.servoAngleTextBox.Text = value.ToString(); }
        }

        private float Voltage
        {
            get { return Convert.ToSingle(this.voltageLabel.Text); }
            set { this.voltageLabel.Text = value.ToString(); }
        }

        private double Latitude
        {
            get { return Convert.ToDouble(this.latitudeLabel.Text); }
            set { this.latitudeLabel.Text = value.ToString(); }
        }

        private double Longitude
        {
            get { return Convert.ToDouble(this.longitudeLabel.Text); }
            set { this.longitudeLabel.Text = value.ToString(); }
        }

        private double Altitude
        {
            get { return Convert.ToDouble(this.altitudeLabel.Text); }
            set { this.altitudeLabel.Text = value.ToString(); }
        }

        private double AltitudeGPS
        {
            get { return Convert.ToDouble(this.altitudeGPSLabel.Text); }
            set { this.altitudeGPSLabel.Text = value.ToString(); }
        }

        private double Airspeed
        {
            get { return Convert.ToDouble(this.airspeedLabel.Text); }
            set { this.airspeedLabel.Text = value.ToString(); }
        }

        private double SpeedGPS
        {
            get { return Convert.ToDouble(this.speedGPSLabel.Text); }
            set { this.speedGPSLabel.Text = value.ToString(); }
        }

        private double Pressure
        {
            get { return Convert.ToDouble(this.pressureLabel.Text); }
            set { this.pressureLabel.Text = value.ToString(); }
        }

        private void angleTrackbar_ValueChanged(object sender, EventArgs e)
        {
            //Disable event handler to prevent circular events
            this.servoAngleTextBox.TextChanged -= servoAngleTextBox_TextChanged;

            ServoAngle = angleTrackbar.Value;

            //Renable event handler
            this.servoAngleTextBox.TextChanged += servoAngleTextBox_TextChanged;
        }

        private void servoAngleTextBox_TextChanged(object sender, EventArgs e)
        {
            //Disable event handler to prevent circular events
            this.angleTrackbar.ValueChanged -= angleTrackbar_ValueChanged;

            //Parse() allows using the negative sign
            Decimal outDecimal;
            if (Decimal.TryParse(servoAngleTextBox.Text.ToString(), out outDecimal))
            {
                ServoAngle = Convert.ToInt32(outDecimal);
                if (ServoAngle <= this.angleTrackbar.Maximum && ServoAngle >= this.angleTrackbar.Minimum)
                    this.angleTrackbar.Value = ServoAngle;
            }
            
            //Renable event handler
            this.angleTrackbar.ValueChanged += angleTrackbar_ValueChanged;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Presenter.Connect();
        }

        private void missionStartButton_Click(object sender, EventArgs e)
        {
            countMissionTime = true;
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            Presenter.ReleaseOverride();
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            Presenter.AudioOverride();
        }

        private void takePhotoButton_Click(object sender, EventArgs e)
        {
            Presenter.TakePhoto();
        }

        private void viewPhotosButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void UpdateView()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(UpdateView));
            }
            else
            {
                try
                {
                    //Update properties
                    if(countMissionTime)
                        this.MissionTime++;

                    this.PacketCount = Packets[Packets.Count - 1].packetCount;
                    this.SatelliteCount = Packets[Packets.Count - 1].satellitesGPS;
                    this.Voltage = Packets[Packets.Count - 1].voltage;
                    this.Latitude = Packets[Packets.Count - 1].latitudeGPS;
                    this.Longitude = Packets[Packets.Count - 1].longitudeGPS;
                    this.Altitude = Packets[Packets.Count - 1].altSensor;
                    this.AltitudeGPS = Packets[Packets.Count - 1].altitudeGPS;
                    this.Airspeed = Packets[Packets.Count - 1].speed;
                    this.SpeedGPS = Packets[Packets.Count - 1].speedGPS;
                    this.Pressure = Packets[Packets.Count - 1].pressure;
                }
                catch(ArgumentOutOfRangeException)
                {
                    //do nothing
                }

                //Update chart series
                updateCharts(Packets[Packets.Count - 1]);
            }
        }

        private void updateCharts(Model.TelemetryPacket packet)
        {
            Series updateSeries;

            updateSeries = this.chart1.Series["SeriesAltitudeAltimeter"];
            updateSeries.Points.AddXY(PacketCount, packet.altSensor);

            updateSeries = this.chart1.Series["SeriesAltitudeGPS"];
            updateSeries.Points.AddXY(PacketCount, packet.altitudeGPS);

            updateSeries = this.chart1.Series["SeriesSpeedPitot"];
            updateSeries.Points.AddXY(PacketCount, packet.speed);

            updateSeries = this.chart1.Series["SeriesSpeedGPS"];
            updateSeries.Points.AddXY(PacketCount, packet.speedGPS);

            updateSeries = this.chart1.Series["SeriesPressure"];
            updateSeries.Points.AddXY(PacketCount, packet.pressure);

            updateSeries = this.chart1.Series["SeriesTemperature"];
            updateSeries.Points.AddXY(PacketCount, packet.temp);

            //updateSeries = this.chart1.Series["SeriesAltitudeAltimeter"];
            //updateSeries.Points.AddXY(packet.altSensor);

            foreach (ChartArea area in this.chart1.ChartAreas)
            {
                area.RecalculateAxesScale();
            }
        }

        private void GroundStationForm_Load(object sender, EventArgs e)
        {
            // Chart setup
            return;
        }
    }
}
