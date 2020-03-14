using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManager.View;
using CarManager.Controllers;

namespace CarManager1
{
    class Program
    {

        static void Main(string[] args)
        {
            CarController controller = new CarController();

            controller.Run();

        }
    }
}
