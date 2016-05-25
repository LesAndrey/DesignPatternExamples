namespace GoF_TryOut.Commands.Example2.StraightCode
{
    public class Controller : IController
    {
        private readonly Command _commandA;
        private readonly Command _commandB;
        private readonly Command _commandC;
        private readonly Command _commandD;

        public Controller(Command commanadA, Command commandB, Command commandC, Command commandD)
        {
            _commandA = commanadA;
            _commandB = commandB;
            _commandC = commandC;
            _commandD = commandD;
        }

        public void PressA()
        {
            _commandA.Execute();
        }

        public void PressB()
        {
            _commandB.Execute();
        }

        public void PressС()
        {
            _commandC.Execute();
        }

        public void PressD()
        {
            _commandD.Execute();
        }
    }
}