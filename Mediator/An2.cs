namespace Mediator
{
    public class An2 : Plane
    {
        public An2(string flight, ITrafficControl traficControle) : base(flight, traficControle)
        {
        }

        public override int MaxAltitude => 4500;
    }
}