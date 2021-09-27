using GoldBadgePractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace YoutubeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_DisplayYoutube()
        {
            //Arrange - what does my method need in order to run
            Youtube_Repository repo = new Youtube_Repository();

            //Act
            int listOfYoutubeVideos = repo.DisplayYoutubeList().Count;

            //Assert
            Assert.AreEqual(0, listOfYoutubeVideos);
        }

        [TestMethod]
        public void Test_AddYoutubeVideo()
        {
            //Arrange
            YouTube youtube = new YouTube();
            Youtube_Repository repo = new Youtube_Repository();

            //Act
            int beforeCount = repo.DisplayYoutubeList().Count;
            repo.AddVideosToYouTube(youtube);
            int actual = repo.DisplayYoutubeList().Count();
            int expected = beforeCount + 1;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Test_UpdateExistingVideo()
        {
            //Arrange
            Youtube_Repository repo = new Youtube_Repository();
            YouTube oldVideo = new YouTube(40000, "BBC News", "Afragistan Evaculation", 5000, "Failure from the globe", 300, DateTimeOffset.Now, TypesOfVideos.News);
            repo.AddVideosToYouTube(oldVideo);
            YouTube updatevideo = new YouTube(10000 , "BBC News", "Taliban go to war", 3000, "Evaculation completed, but left others behind", 200, DateTimeOffset.Now, TypesOfVideos.News);
            string name = "BBC News";

            //Act
            bool result = repo.UpdateExisitingYouTube(name, updatevideo);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_GetVideoByType()
        {
            //Arrange
            Youtube_Repository repo = new Youtube_Repository();
            YouTube testVideo = new YouTube(100000, "NBA", "Michael Jordan Highlights", 10000, "GOAT doing GOAT things", 400, DateTimeOffset.Now, TypesOfVideos.Basketball);
            repo.AddVideosToYouTube(testVideo);

            //Act
            var results = repo.GetVideoByName(1);
            var expectedOuting = 1;
            var actualOuting = (int)results.TypeOfEvent;

            //Assert
            Assert.AreEqual(expectedOuting, actualOuting);
        }
    }
}
