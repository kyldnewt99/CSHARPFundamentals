using System;
using System.Collections.Generic;
using _08_StreamingContent_Console.UI;
using _10_StreamingContent_UIRefactor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_UIRefactor_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainList()
        {
            //Arrange 
            List<String> commandList = new List<String> { "1", "6" };// 1 = show all content, 6 = exit
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);

            //Act
            program.Run();
            Console.WriteLine(console.Output);

            //Assert (that a certain item has been included in the output)
            Assert.IsTrue(console.Output.Contains("Your driver for the night is a baby"));

        }

        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            //Arrange
            var customDescription = "these are my custom thoughts on this movie";
            var commandList = new List<String> { "3", "This is the title", customDescription, "42", "3", "4", "1", "6" };
            var mockConsole = new MockConsole(commandList);
            var ui = new ProgramUI(mockConsole);
            //Act
            ui.Run();
            Console.WriteLine(mockConsole.Output);
            //Assert
            Assert.IsTrue(mockConsole.Output.Contains(customDescription));

        }

        [TestMethod]
        public void RemoveFromList_ShouldSeeRemovedMessage()
        {
            //Arrange
            var commandList = new List<String>
            {
                "4", "3","6"
            };
            var fakeConsole = new MockConsole(commandList);
            var ui = new ProgramUI(fakeConsole);

            //Act
            ui.Run();
            Console.WriteLine(fakeConsole);

            //Assert
            Assert.IsTrue(fakeConsole.Output.Contains("test movie successfully removed!"));
        }
    }
}
