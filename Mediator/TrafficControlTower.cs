using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    class TrafficControlTower : ITrafficControl
    {
        private const int AltitudeStep = 300;
        private readonly List<Plane> _planesUnderGuidance = new List<Plane>();

        public void RegistryPlane(Plane plane)
        {
            if (!_planesUnderGuidance.Contains(plane))
            {
                _planesUnderGuidance.Add(plane);
                Console.WriteLine($"The {plane.Flight} flight has been registered");
            }
        }

        public void ReceivePlaneLocation(Plane plane)
        {
            foreach (var currentPLane in _planesUnderGuidance.Where(x=> !x.Equals(plane)))
            {
                if (Math.Abs(currentPLane.Altitude-plane.Altitude)< AltitudeStep)
                {
                    Console.WriteLine($"The {plane.Flight}({plane.Altitude}) flight intrude into lantitude of the {currentPLane.Flight}({currentPLane.Altitude}) flight");
                    currentPLane.WarnOfIntrusion(plane);
                    plane.Climb(AltitudeStep);
                }
            }
        }
    }
}