using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 142;
            string username = "Sandy";
            bool equals = age == 12;
            bool userIsAdam = username == "Spongebob";

            bool notEqual = age != 1001;
            bool userIsNotPatrick = username != "Patrick";
            bool testBool = false;

            List<String> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool greaterThan = age > 10;
            bool greaterThanOrEqual = age >= 142;
            bool lessThan = age < 9001;
            bool lessThanOrEqual = age <= 142;

            bool orValue = greaterThan || lessThan;
            bool anotherOr = age < 9005 || username == "banana";

            bool andValue = greaterThan && lessThan;
            bool anotherAnd = username == "Sandy" && age >= 42;


        }
    }
}
