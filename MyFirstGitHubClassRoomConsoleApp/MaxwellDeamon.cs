using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class MaxwellDeamon
    {
        public Container cont { get; set; }
        public MaxwellDeamon(Container c)
        {
            cont = c;
        }
        public void SortContainer()
        {
            foreach (Particle item in cont.LeftCon)
            {
                if (item.Hot)
                {
                    cont.LeftCon.Remove(item);
                    cont.RightCon.Add(item);
                }
            }
            foreach (Particle item in cont.RightCon)
            {
                
                if (!item.Hot)
                {
                    cont.RightCon.Remove(item);
                    cont.LeftCon.Add(item);
                }
                
            }
            cont.Show();
        }
    }
}
