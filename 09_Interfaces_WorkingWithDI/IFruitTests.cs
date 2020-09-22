using System;
using System.Collections.Generic;
using _09_Interfaces_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            var output = banana.Peel(); // "var" will assume whatever class it needs to be based on the context around it

            Console.WriteLine(output);
            Banana bananaTwo = new Banana(); //This gives the same output at "Ifruit banana (line 13) b/c inheritance. you can use Ifruit (interface) as a type, but can't make an IFruit object
            var anotherOutput = bananaTwo.Peel();
            Console.WriteLine(anotherOutput);
        }
        [TestMethod]
        public void InterfacesInCollections()
        {
            var orangeObject = new Orange();
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                new Orange(true),
                orangeObject,
                new Strawberry(),
                new Apple()

            };
            foreach (var oneFruit in fruitSalad)
            {
                Console.WriteLine(oneFruit.Name);
                Console.WriteLine(oneFruit.Peel());
                Assert.IsInstanceOfType(oneFruit, typeof(IFruit));
                Assert.IsInstanceOfType(orangeObject, typeof(Orange));
            }
        }
        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit it called {fruit.Name}.";
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
        }
        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Grape(),
            new Orange(true),
            new Banana(),
            new Orange(),
            new Banana(),
            new Grape(),
            new Orange(true),
            //new Apple(),
            //new Strawberry()
            };
            Console.WriteLine("Is the orange peeled?");
            foreach(var oneFruit in fruitSalad)
            {
                if (oneFruit is Orange orangeObject) // seeing if oneFruit is an orange. if it is, it's being cast as "orangeObject". Called Pattern Matching
                {
                    if (orangeObject.IsPeeled)
                    {
                        Console.WriteLine("This is a peeled orange.");
                        orangeObject.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("Hey! Don't squeeze that yet! It isn't peeled!");
                    }
                }
                else if (oneFruit.GetType()==typeof(Grape))//checking if it is a grape, but not casting it
                {
                    var newGrapeObject = (Grape)oneFruit; //casting 
                    Console.WriteLine("This is a grape");
                }
                else if (oneFruit.IsPeeled)
                {
                    Console.WriteLine("That is a peeled banana");
                }
                else
                {
                    Console.WriteLine("One unpeeled banana... weird to see in a fruit salad.");
                }
            }
        }
    }
        
}
