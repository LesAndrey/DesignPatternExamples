using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var trafficControleTower= new TrafficControlTower();
            var flight1 = new An148("An148-KIE", trafficControleTower);
            var flight2 = new An2("An2-LWO", trafficControleTower);
            var flight3 = new Tu144("Tu144-ALM", trafficControleTower);

            flight1.Altitude=1000;
            flight2.Altitude = 1000;
            flight3.Altitude = 1000;
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
