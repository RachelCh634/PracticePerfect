using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace איקס_עיגול
{
    internal class GameManagement : board
    {
        public board b1 { get; set; }
        public Player[] players { get; set; }
        public GameManagement()
        {
            b1 = new board();
            players = new Player[2];
            SelectionPlayers();
        }
        public void SelectionPlayers()
        {
            char c = ' ';
            char xo = ' ';
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("To play against a person, press 1, To play against a computer, press 2.");
                int x = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    Console.WriteLine("enter x or o");
                    xo = char.Parse(Console.ReadLine());
                    while (xo != 'x' && xo != 'o')
                    {
                        Console.WriteLine("enter only x or o");
                        xo = char.Parse(Console.ReadLine());
                    }
                    c = xo;
                }
                else
                {                  
                    if (c == 'x')
                        xo = 'o';
                    else
                        xo = 'x';
                    Console.WriteLine("the sign is: "+xo);
                } 
                switch (x)
                {
                    case 1:
                        Console.WriteLine("enter your name");
                        string name = Console.ReadLine();
                        players[i] = new person(name, xo);
                        break;
                    case 2:
                        players[i] = new computer("computer", xo);
                        break;
                }
            }
        }

        public void ManaGturn()
        {        
            int turn = 0;
            bool flag = false;
            bool winner = false;
            while (!flag)
            {
                turn=ChangeTurn(turn);
                Console.WriteLine("The turn of :" + players[turn].name);
                int[] place = players[turn].ChoosePlace();
                while (!b1.IsAvailable(place[0], place[1]))
                {
                    Console.WriteLine("enter other place ");
                    place = players[turn].ChoosePlace();
                }
                b1.Posting(place[0], place[1], players[turn].sign);
                b1.print();
                flag = b1.Win(players[turn].sign);
                if (flag)
                    break;
                flag = b1.IsFull();
            }
            if (b1.IsFull() && b1.Win(players[0].sign) == false && b1.Win(players[1].sign) == false)
                Finish('!');
            else
            {
                if (winner = b1.Win(players[0].sign))
                { Finish(players[0].sign); }
                else
                    if (winner = b1.Win(players[1].sign))
                { Finish(players[1].sign); }
            }
        }
        public int ChangeTurn(int turn)
        {
            if (turn == 0)
                turn = 1;
            else
                turn = 0;
            return turn;
        }
        public void Finish(char c)
        {
            if (c != '!')
            {
                Console.WriteLine("the win is " + c+", the game is over!!!");
            }
            else
                Console.WriteLine("the game is over, good by!");
        }
    }
}

