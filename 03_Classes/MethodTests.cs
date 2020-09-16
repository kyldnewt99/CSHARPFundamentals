using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecution()
        {
            Greeter greeter = new Greeter();
            greeter.sayHello();

            greeter.sayHello("Squidward");
            greeter.sayHello("Geeter");
            greeter.sayHello("Mr. Krabs");
            greeter.sayHello("867-5309");

            greeter.GetRandomGreeting();
        }
    }
}
