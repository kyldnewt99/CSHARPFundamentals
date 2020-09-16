using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Greeter
    {
        public void sayHello(string name)
        {
            Console.WriteLine($"Hello there, {name}");
        }
        public void sayHello()
        {
            Console.WriteLine("Hello Stranger");
        }

        Random rando = new Random();

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Howdy", "Sup", "Hola", "Suh dude", "Hi y'all", "Guten Tag", "Hello There", "Ni Hao", "Yo bro", "Waddup", "Wasuuuup", "Hi" };
            int randomNumber = rando.Next(0, availableGreetings.Length);
            string randoGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine($"{randoGreeting}"); // since we aren't passing through anything else, you can just put Console.WriteLine(randoGreeting)
        }
}
    
}
