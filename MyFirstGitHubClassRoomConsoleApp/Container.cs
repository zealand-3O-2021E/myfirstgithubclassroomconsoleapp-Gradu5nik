using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Container
    {
        public List<Particle> RightCon { get; set; }
        public List<Particle> LeftCon { get; set; }
        public Container()
        {
            RightCon = new List<Particle>();
            LeftCon = new List<Particle>();
            Random rnd = new Random();
            for (int i = 0; i <10; i++)
            {
                RightCon.Add(new Particle());
                LeftCon.Add(new Particle());
            }
        }
        public void Show()
        {
            Console.WriteLine("===============================");
            foreach (Particle item in LeftCon)
            {
                if (item.Hot == true)
                {
                    Console.WriteLine("hot");
                }
                else { Console.WriteLine("cold"); }
            }
            Console.WriteLine("==============MMM=================");
            foreach (Particle item in RightCon)
            {
                if (item.Hot == true)
                {
                    Console.WriteLine("hot");
                }
                else { Console.WriteLine("cold"); }
            }
            Console.WriteLine("===============================");
        }
        

    }
}
