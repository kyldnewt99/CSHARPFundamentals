using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction
{
    public class Banana : IFruit
    {
        public string Name { get { return "Banana"; } }
        public bool IsPeeled { get; private set; }
        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana";
        }

    }

    public class Orange : IFruit
    {
        public string Name { get { return "Orange"; } }
        public bool IsPeeled { get; private set; }
        public Orange() { }//constructor

        public Orange(bool isPeeled)//overloaded constructor
        {
            IsPeeled = isPeeled;
        }


        public string Peel()
        {
            IsPeeled = true;
            return "You peel the orange";
        }
        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }
    public class Grape : IFruit
    {
        public string Name { get { return "Grape"; } }
        public bool IsPeeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
    public class Strawberry : IFruit
    {
        public string Name { get { return "Strawberry"; } }
        public bool IsPeeled { get; } = false;
        public string Peel()
        {
            return "Strawberries aren't peeled";
        }
    }
    public class Apple : IFruit
    {
        public string Name { get { return "Apple"; } }
        public bool IsPeeled { get; private set; } 
        public string Peel()
        {
            return "Peeling apples is optional. I prefer peeled.";
        }

    }
}
