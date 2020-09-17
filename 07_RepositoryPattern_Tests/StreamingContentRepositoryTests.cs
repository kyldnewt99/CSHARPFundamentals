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

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Oceans 8", "do crime?", 100, MaturityRating.PG_13, true, GenreType.Action);
            _repo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Oceans 8");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange
            StreamingContent updatedContent = new StreamingContent("Italian Job", "do crime? in Italy", 100, MaturityRating.PG_13, true, GenreType.Action);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Oceans 8", updatedContent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //arrange
            StreamingContent foundContent = _repo.GetContentByTitle("Oceans 8");
            //Act
            bool removeResult = _repo.DeleteExistingContent(foundContent);
            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
