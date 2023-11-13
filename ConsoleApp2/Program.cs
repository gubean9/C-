namespace ConsoleApp2
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class UserService
    {
        public void Login(User user) { }
        public void Purchase(User user) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}