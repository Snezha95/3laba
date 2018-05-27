using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInCity
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            if (game.Load())
            {
                Console.WriteLine("Имя первого игрока: ");
                game.SetNameGamer1(Console.ReadLine());
            }
            else
                Console.WriteLine("Не найден файл со списком городов!");
            Console.ReadKey();
        }
    }
}
