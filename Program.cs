namespace איקס_עיגול
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("hello michal amd cute girls!!");
                Console.WriteLine("hello to our gaming, to begin the game press 1, to stop the game enter 2");
                int x = int.Parse(Console.ReadLine());
                if (x == 2)
                    flag = false;
                if(!flag)
                    break;
                GameManagement game = new GameManagement();
                game.ManaGturn();
            }

        }
    }
}