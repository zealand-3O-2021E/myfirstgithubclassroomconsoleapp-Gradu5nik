using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Particle
    {

        public bool Hot { get; set; }
        public Particle()
        {
            Random rnd = new Random();
            Hot = rnd.Next(0, 1) == 1 ? true : false;
        }
    }
}
