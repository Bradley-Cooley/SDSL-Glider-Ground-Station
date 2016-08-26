using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDSL.GliderGroundStation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new Model.VehicleCommunication();
            var view = new View.GroundStationForm();

            var presenter = new Presenter.GroundStationPresenter(model, view);

            Application.Run(view);
        }
    }
}
