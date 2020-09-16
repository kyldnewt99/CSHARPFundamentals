using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
       
            public void AddToDirectory_ShouldGetCorrectBoolean()
            {
            //Arrange: Where we set up the pieces we need in order to perform the test we desire to run.

            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act: Where we run the code that we want to test.

            bool addResult = repository.AddContentToDirectory(content);

            //Assert: Where we prove whether the code did what we intended it to do.

            Assert.IsTrue(addResult);

            }
        [TestMethod]
        public void GetDirectoryMethod_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent newObject = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(newObject);

            //Act
            List<StreamingContent> listOfContents = repo.GetContents();

            //Assert
            bool directoryHasContent = listOfContents.Contains(newObject);
            Assert.IsTrue(directoryHasContent);

        }
    }
}
