using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace איקס_עיגול
{
    internal class computer : Player
    {
        public computer(string name, char sign) : base(name, sign) { }
        public override int[] ChoosePlace()
        {
            int[] place = new int[2];
            Random r = new Random();
            place[0] = r.Next(0, 3);
            place[1] = r.Next(0, 3);
            return place;
        }
    }
}
