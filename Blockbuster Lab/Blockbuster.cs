using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blockbuster_Lab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>();

            List<string> test = new List<string>(){
                "That's",
                "a",
                "spicy",
                "meat",
                "ball"
            };

            Movie d = new DVD("Citizen Kane", Genre.Drama, 1,
                new List<string>() { "Just rosebud.", "Damn thats a big sexy rosebud!", "The rosebuds were the friends we made along the way.." });
            Movie d1 = new DVD("Grown Ups", Genre.Comedy, 2,
                new List<string>() { "Adam Sandler making those Adam Sandler noises.", "Owen Wilson saying WOW.", "Kevin James eating." });
            Movie d2 = new DVD("The Thing", Genre.Horror, 3,
                new List<string>() { "Yo it's the thing!", "Now that was pretty scary!", "Hey you're not Kurt Russell." });
            Movie v = new VHS("Titanic", Genre.Romance, 4,
                new List<string>() { "Uh oh! The ship is sinking!", "Get to the lifeboats!", "Bye Jack." });
            Movie v1 = new VHS("Terminator", Genre.Action, 5,
                new List<string>() {"Naked Arnold.","Motorcycles and guns.","I'll be back later for lunch.."});
            Movie v2 = new VHS("The Shining", Genre.Horror, 5, 
                new List<string>() { "Nice place you got here!","Redrum!","Bathroom scene."});

            Movies.Add(d);
            Movies.Add(d1);
            Movies.Add(d2);
            Movies.Add(v);
            Movies.Add(v1);
            Movies.Add(v2);
        }

        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Movies.ElementAt(i).Title}");
            }
        }

        public Movie CheckOut()
        {
            PrintMovies();
            Console.Write($"\nWhich movie would you like to checkout (select [{0}-{Movies.Count}]):   ");
            string input = Console.ReadLine();
            int movieNum = int.Parse(input);
            Movie checkOut = Movies.ElementAt(movieNum - 1);
            Console.WriteLine();
            checkOut.PrintInfo();
            return checkOut;
        }
    }
}
