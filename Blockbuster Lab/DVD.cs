using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"Which scene from {Title} would you like to watch? Select from [{1}-{this.Scenes.Count}]");
            string input = Console.ReadLine();
            int sceneNum = int.Parse(input);

            Console.WriteLine($"\n{sceneNum}: {this.Scenes.ElementAt(sceneNum-1)}");
        }

    }
}
