using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UIRefactor
{
    public class MockConsole: IConsole
    {
        public Queue<string> UserInput; //property

        public string Output; //property
        public MockConsole(IEnumerable<string> input) //generic collection. This is a constructor that takes in user input
        {
            UserInput = new Queue<string>(input); //passing in input
            Output = "";
        }

        public void Writeline(string s)
        {
            Output += s + "\n";
        }
        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
        public void Clear()
        {
            Output += "Called Clear Method\n";
        }
        public string ReadLine()
        {
            return UserInput.Dequeue();
        }
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }
    }
}
