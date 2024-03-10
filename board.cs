using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace איקס_עיגול
{
    internal class board
    {
        public char[,] metrix = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

        public bool IsFull()
        {
            for (int i = 0; i < metrix.GetLength(0); i++)
            {
                for (int j = 0; j < metrix.GetLength(1); j++)
                {
                    if (metrix[i, j] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void print()
        {
            for (int i = 0; i < metrix.GetLength(0); i++)
            {
                for (int j = 0; j < metrix.GetLength(1); j++)
                {
                    { Console.Write(metrix[i, j] + " "); }
                }
                Console.WriteLine();
            }
        }

        public bool IsAvailable(int i, int j)
        {
            if (metrix[i, j] == '-')
            {
                return true;
            }
            return false;
        }

        public void Posting(int i, int j, char x)
        {
            metrix[i, j] = x;
        }

        public bool Win(char value)
        {
            for (int i = 0; i < metrix.GetLength(0); i++)
            {
                if (i == 1)
                {
                    for (int j = 0; j < metrix.GetLength(1); j++)
                    {
                        if (metrix[i, j] == value)
                        {
                            if (metrix[i - 1, j] == value && metrix[i + 1, j] == value)
                                return true;
                        }
                    }
                }
                for (int j = 0; j < metrix.GetLength(1); j++)
                {
                    if (j == 1)
                    {
                        if (metrix[i, j] == value)
                        {
                            if (metrix[i, j - 1] == value && metrix[i, j + 1] == value)
                                return true;
                        }
                    }
                    if (i == 1 && j == 1)
                    {
                        if (metrix[i, j] == value)
                        {
                            if (metrix[i + 1, j + 1] == value && metrix[i - 1, j - 1] == value || metrix[i - 1, j + 1] == value && metrix[i + 1, j - 1] == value)
                                return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
