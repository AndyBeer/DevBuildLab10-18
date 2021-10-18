using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_18
{
    class MovieDB
    {
        //create a new list of movie objects
        public List<Movie> MoviesList = new List<Movie>();
        public MovieDB()
            //fill that list
        {
            MoviesList.Add(new Movie("Star Wars", "scifi", "Space ninjas with light swords fight robots and stuff."));
            MoviesList.Add(new Movie("War of the Worlds", "scifi", "Aliens attack Earth from another world."));
            MoviesList.Add(new Movie("Jurassic Park", "scifi", "DINO DNA!"));
            MoviesList.Add(new Movie("Finding Nemo", "animated", "A fish looks for another fish."));
            MoviesList.Add(new Movie("Lion King", "animated", "A lion becomes a king of lions."));
            MoviesList.Add(new Movie("Halloween", "horror", "Some creep in a mannequin mask stabs people."));
            MoviesList.Add(new Movie("TX Chainsaw Massacre", "horror", "Some creep in a person's face mask chainsaws people."));
            MoviesList.Add(new Movie("Arachnaphobia", "horror", "Some creepy spiders bite people."));
            MoviesList.Add(new Movie("Titanic", "drama", "A big boat sinks.")); 
            MoviesList.Add(new Movie("Knives Out", "drama", "An author dies and mystery ensues."));

            
        }
        public void PrintCategory(int userInput)
        {
            
            for (int i = 0; i < MoviesList.Count; i++)
            {
                if (userInput == 1 && MoviesList[i].Category.Contains("animated"))
                {
                    
                    Console.WriteLine(MoviesList[i].Name);
                    Console.WriteLine("");
                }
                else if (userInput == 2 && MoviesList[i].Category.Contains("scifi"))
                {
                    Console.WriteLine(MoviesList[i].Name);
                    Console.WriteLine("");
                }
                else if (userInput == 3 && MoviesList[i].Category.Contains("drama"))
                {
                    Console.WriteLine(MoviesList[i].Name);
                    Console.WriteLine("");
                }
                else if (userInput == 4 && MoviesList[i].Category.Contains("horror"))
                {
                    Console.WriteLine(MoviesList[i].Name);
                    Console.WriteLine("");
                }

            }
            
        }
       
    }
}
