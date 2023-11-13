using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {   
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}