﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blockbuster_Lab
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }

    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Category: {this.Category}");
            Console.WriteLine($"Run Time: {this.RunTime}");
        }
        
        public void PrintScenes()
        {
            for (int i = 0; i < this.Scenes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {this.Scenes.ElementAt(i)}");
            }
        }

        public abstract void Play();
    }
}
