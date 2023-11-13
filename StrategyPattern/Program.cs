namespace StrategyPattern
{
    void class MallardDuck
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            RubberDuck rubberDuckie = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();

            ModelDuck model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuckie.PerformQuack();
            decoy.PerformQuack();

            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}