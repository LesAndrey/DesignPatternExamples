namespace Mediator
{
    public interface ITrafficControl
    {
        void RegistryPlane(Plane plane);
        void ReceivePlaneLocation(Plane plane);
    }
}