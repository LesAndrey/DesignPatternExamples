namespace Mediator
{
    class Waszka : Plane
    {
        public Waszka(string flight, ITrafficControl traficControle) : base(flight, traficControle)
        {
        }

        public override int MaxAltitude => 10000;
    }
}