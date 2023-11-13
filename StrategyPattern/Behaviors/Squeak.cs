namespace StrategyPattern.Behaviors
{
    internal class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}