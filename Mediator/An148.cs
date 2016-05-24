namespace Mediator
{
    public class An148 : Plane
    {
        public An148(string flight, ITrafficControl traficControle) : base(flight, traficControle)
        {
        }

        public override int MaxAltitude => 12500;
    }
}