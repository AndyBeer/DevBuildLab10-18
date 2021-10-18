using System;

namespace DevBuildLab10_18
{
    class Program
    {
        static void Main(string[] args)
        {

            //Couldnt figure out how to properly use the MoviesList.Sort() functionality - assuming I need to create a method in the MovieDB class in order to use it within the PrintCategory method.

            bool keepGoing = true;
            MovieDB MovieDB = new MovieDB();

            Console.WriteLine("Welcome to the movie list application.");

            while (keepGoing)
            {
                string response = GetInput("What category are you interested in?\n1: Animated\n2: Scifi\n3: Horror\n4: Drama\n");

                try
                {
                    int menunum = int.Parse(response);
                    MovieDB.PrintCategory(menunum);
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid response.  Please select \"1\", \"2\", \"3\" or \"4\".\n");
                    continue;
                }
                keepGoing = ContinueLoop("Would you like to try again? y/n");
            }
            

        }
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            return response;
        }
        public static bool ContinueLoop(string question)
        {
            string answer = GetInput(question);
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("OK, goodbye!");
                return false;
            }
            else
            {
                return ContinueLoop("I'm sorry, I didnt catch that.  Please input y to try again, or n to exit.");
            }
        }

    }
}
