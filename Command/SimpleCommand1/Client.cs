namespace GoF_TryOut.Commands.Example2.StraightCode
{
    public class Client
    {
        public Client()
        {
            var heroA= new HeroA();
            var controller = new Controller(new Command(heroA.Jump), new Command(heroA.Shoot), new Command(heroA.Run), new Command(heroA.SwapWeapon));
            controller.PressA();
            controller.PressB();
            controller.PressС();
            controller.PressD();
        }
    }
}
