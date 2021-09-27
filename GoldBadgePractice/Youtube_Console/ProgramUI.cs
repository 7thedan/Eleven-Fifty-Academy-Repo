using GoldBadgePractice;
using System;
using System.Collections.Generic;

namespace Youtube_Console
{
    class ProgramUI
    {
        private Youtube_Repository _YoutubeContentRepo = new Youtube_Repository ();
        public void Run()
        {
            SeedContentList();
            Menu();
        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Menu display
                Console.WriteLine("Select a Youtube option:\n" +
                    "1. Create New Video\n" +
                    "2. View All Youtube Videos\n" +
                    "3. Delete Existing Video\n" +
                    "4. Exit");

                //Get user input
                string input = Console.ReadLine();

                //Evaluate user input with a switch
                switch (input)
                {
                    case "1":
                        //Create a new item
                        CreateNewItem();
                        break;
                    case "2":
                        //Show all items
                        DisplayAllVideos();
                        break;
                    case "3":
                        //Remove an item from the list
                        DeleteExistingItem();
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        //Methods for the cases go below
        private void CreateNewItem()
        {
            Console.Clear();
            YouTube newVideo = new YouTube();

            //Meal Number
            Console.WriteLine("Enter the meal number for the item:");
            string numberAsString = Console.ReadLine();
            newVideo.NumberOfViews = int.Parse(numberAsString);

            //Meal Name
            Console.WriteLine("Enter the name of the meal:");
            newVideo.Name = Console.ReadLine();

            //Description
            Console.WriteLine("Enter a description of the meal:");
            newVideo.Channel = Console.ReadLine();

            //Ingredients
            Console.WriteLine("Enter the ingredients in the meal:");
            string likesAsString = Console.ReadLine();
            newVideo.NumberOfLikes = int.Parse(numberAsString);

            //Price
            Console.WriteLine("Enter the price of the meal:");
            string dislikeAsString = Console.ReadLine();
            newVideo.NumberOfDislikes = int.Parse(dislikeAsString);

            _YoutubeContentRepo.AddVideosToYouTube(newVideo);

            Console.Clear();
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
        private void DisplayAllVideos()
        {
            Console.Clear();

            List<YouTube> listofVideoContent = _YoutubeContentRepo.GetYoutubeList();

            foreach (YouTube videoName in listofVideoContent)
            {
                Console.WriteLine($"Video list of likes is: {videoName.NumberOfLikes}\t" +
                    $"Video name: {videoName.Name}\t" +
                    $"Video price: {videoName.Channel}\n" +
                    $"Video description: {videoName.NumberOfViews}\t" +
                    $"Video ingredients include: {videoName.Uploaded}\n");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        private void DeleteExistingItem()
        {
            DisplayAllVideos();

            //Get the name they want to delete
            Console.WriteLine("\nEnter the name of the meal you want to remove:");
            string input = Console.ReadLine().ToLower();

            //call the delete method
            bool wasDeleted = _YoutubeContentRepo.RemoveVideosFromYoutube(input);

            //If the content was deleted, say it was, otherwise say it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The meal was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The meal could not be deleted.");
            }
        }
        //Seed Method
        private void SeedContentList()
        {
            YouTube houseofHighLights = new YouTube(50000, "House of Highlights", "Kobe Bryant 2009-2012 Highlight",1000000, "KOBE IS DA GOAT", 0, DateTimeOffset.Now, TypesOfVideos.Basketball);
            YouTube chrisSmmove = new YouTube(2000, "Chris Smoove", "Ben Simmons Traded to ?", 500, "BRICK SIMMONS", 50, DateTimeOffset.Now, TypesOfVideos.News){

            };
            YouTube bbcNews = new YouTube(40000, "BBC News", "Afragistan Evaculation", 5000, "Failure from the globe", 300, DateTimeOffset.Now, TypesOfVideos.News);

            _YoutubeContentRepo.AddVideosToYouTube(houseofHighLights);
            _YoutubeContentRepo.AddVideosToYouTube(chrisSmmove);
            _YoutubeContentRepo.AddVideosToYouTube(bbcNews);
        }
    }

}
