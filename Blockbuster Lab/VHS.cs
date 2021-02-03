using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = 0;
        }

        public override void Play()
        {
            if (CurrentTime >= Scenes.Count)
            {
                Console.WriteLine("Movie is finished. Rewinding.");                
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Movie is finished. Rewinding..");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Movie is finished. Rewinding...\n\n");
                System.Threading.Thread.Sleep(2000);
                Rewind();
            }
            Console.WriteLine($"Scene {this.CurrentTime+1}: {Scenes.ElementAt(this.CurrentTime)}");
            this.CurrentTime++;
        }

        public void Rewind()
        {
            this.CurrentTime = 0;
        }



    }
}
