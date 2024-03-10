using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace איקס_עיגול
{
    internal class person : Player
    {
        public person(string name, char c) : base(name, c) { }

        public override int[] ChoosePlace()
        {
            int y;
            int[] place = new int[2];
            Console.WriteLine("enter line");
            y = int.Parse(Console.ReadLine());
            while (y < 0 || y > 2)
            {
                Console.WriteLine("enter connect line");
                y = int.Parse(Console.ReadLine());
            }
            place[0] = y;
            Console.WriteLine("enter colum");
            y = int.Parse(Console.ReadLine());
            while (y < 0 || y > 2)
            {
                Console.WriteLine("enter connect colum");
                y = int.Parse(Console.ReadLine());
            }
            place[1] = y;
            return place;
        }

    }
}
