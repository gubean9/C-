using System.Xml.Linq;

namespace ConsoleApp1
{
    public class User
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public void Login()
        {
            Console.WriteLine(Name);
        }

        public void Purchase()
        {
            Console.WriteLine(Age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User TOM = new User();
            TOM.Name = "톰";
            TOM.Age = 20;

            TOM.Login();
            TOM.Purchase();
        }
    }
}