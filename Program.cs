using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Home_And_Save_Parking_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ASCOM.DriverAccess.Telescope Mount = new ASCOM.DriverAccess.Telescope("ASCOM.iOptron2017.Telescope");
                Mount.Connected = true;
                if (Mount.AtPark)
                {
                    Mount.Unpark();
                }
                Mount.FindHome();
                Mount.SetPark();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
