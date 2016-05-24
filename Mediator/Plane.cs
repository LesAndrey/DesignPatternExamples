using System;

namespace Mediator
{
    public abstract class Plane
    {
        private readonly ITrafficControl _traficControle;
        private int _altitude;
        protected Plane(string flight, ITrafficControl traficControle)
        {
            _traficControle = traficControle;
            Flight = flight;
            _traficControle.RegistryPlane(this);
        }
        public string Flight { get; }

        public int Altitude
        {
            get { return _altitude; }
            set
            {
                _altitude = value;
                Console.WriteLine($"From {Flight} : My altitude {Altitude} ");
                _traficControle.ReceivePlaneLocation(this);
            }
        }

        public abstract int MaxAltitude { get; }

        public void WarnOfIntrusion(Plane intruder)
        {
            Console.WriteLine($"To:{Flight} From:TrafficControleTower : Flight {intruder.Flight} has intruded your altitude.");
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;
            var incoming = (Plane) obj;
            return Flight.Equals(incoming.Flight);
        }

        public override int GetHashCode()
        {
            return Flight.GetHashCode();
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }
    }
}
