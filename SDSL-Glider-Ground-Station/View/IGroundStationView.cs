using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSL.GliderGroundStation.View
{
    public interface IGroundStationView
    {
        List<Model.TelemetryPacket> Packets { get; set; }

        int ServoAngle { get; set; }

        void UpdateView();

        Presenter.GroundStationPresenter Presenter { set; }
    }
}
