namespace Mediator
{
    class Tu144 : Plane
    {
        public Tu144(string flight, ITrafficControl traficControle) : base(flight, traficControle)
        {
        }

        public override int MaxAltitude => 20000;
    }
}