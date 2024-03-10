using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace איקס_עיגול
{
    internal class Player
    {
        public string name { get; set; }
        public char sign { get; set; }

        public Player(string name,char sign)
        {
            this.name = name;
            this.sign = sign;
        }
        public virtual int[] ChoosePlace()
        {
            return new int[] { 0, 0 };
        }
    }
}
