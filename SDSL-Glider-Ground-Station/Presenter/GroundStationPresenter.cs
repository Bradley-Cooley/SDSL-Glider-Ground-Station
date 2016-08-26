using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDSL.GliderGroundStation.View;
using SDSL.GliderGroundStation.Model;

namespace SDSL.GliderGroundStation.Presenter
{
    public class GroundStationPresenter
    {
        private readonly IGroundStationView _view;
        private readonly IVehicleCommunication _model;

        private readonly int MAX_PACKETS = 60;

        public GroundStationPresenter(IVehicleCommunication model, IGroundStationView view)
        {
            this._view = view;
            _view.Presenter = this;

            this._model = model;
            _model.NewTelemetry += _model_NewTelemetry;
            _model.NewPhoto += _model_NewPhoto;
        }

        private void _model_NewPhoto(object sender, EventArgs e)
        {
            //_view.Image
            _view.UpdateView();
        }

        private void _model_NewTelemetry(object sender, EventArgs e)
        {
            if (_model.NumberOfTelemetryPackets >= MAX_PACKETS)
                _view.Packets = _model.getRangeOfRecentPackets(MAX_PACKETS);
            else
                _view.Packets = _model.getRangeOfRecentPackets(_model.NumberOfTelemetryPackets);

            _view.UpdateView();
        }

        internal void Connect()
        {
            _model.openConnections();
        }

        internal void ReleaseOverride()
        {
            _model.commandRelease();
        }

        internal void AudioOverride()
        {
            _model.commandAudio();
        }

        internal void TakePhoto()
        {
            _model.commandPhoto(_view.ServoAngle);
        }
    }
}
