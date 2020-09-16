﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsDeclaration;

            string declared;

            declared = "This is initialized";

            string declarationAndInitialization = "This is both declaring and initializing";

            //Concatenation

            string firstName = "Bobert";
            string lastName = "Billiam";
            string space = " ";
            string concatenatedFullName = firstName + space + lastName;
            int age = 112;
            //composite

            string compositeFullName = string.Format("{2}. Hello, I am {0} {1}. Attorney at law.", firstName, lastName, age);

            //interpolation
            string interpolationFullName = $"{lastName}, {firstName} {lastName}. I am {age}.";

            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolationFullName);
        }
        [TestMethod]
        public void Collections()
        {
            //Arrays
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            Console.WriteLine(stringArray[2]);
            Console.WriteLine(stringArray[0]);
            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);


            //Lists
            List<string> listofStrings = new List<string>();
            List<int> listofIntegers = new List<int>();
            listofStrings.Add("42");
            listofIntegers.Add(42);
            Console.WriteLine(listofIntegers[0]);

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next!");
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            //other examples

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);

        }
    }
}
