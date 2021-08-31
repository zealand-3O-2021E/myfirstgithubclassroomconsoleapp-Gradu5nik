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
            List<Particle> temp = new List<Particle>();
            foreach (Particle item in cont.LeftCon)
            {
                if (item.Hot)
                {
                    temp.Add(item);
                }
                
            }
            cont.LeftCon.RemoveAll(p => p.Hot);
            cont.RightCon.AddRange(temp);
            temp.Clear();
            foreach (Particle item in cont.RightCon)
            {
                
                if (!item.Hot)
                {
                    temp.Add(item);
                }
                
            }
            cont.RightCon.RemoveAll(p =>!p.Hot);
            cont.LeftCon.AddRange(temp);
            cont.Show();
        }
    }
}
