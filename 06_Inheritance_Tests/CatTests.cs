using System;
using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Inheritance_Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void CatTesting()
        {
            Animal firstAnimal = new Animal();
            Cat firstCat = new Cat();
            firstAnimal.Move();
            firstCat.Move();
            firstCat.MakeSound();

            Liger oneLiger = new Liger();
                oneLiger.Move();
            oneLiger.MakeSound();
            //try making other classes that inherit from the animal class
        }
    }
}
