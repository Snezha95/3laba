using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
                Console.WriteLine("Имя второго игрока: ");
                game.SetNameGamer2(Console.ReadLine());
                game.SetPause(5);
                int pause = game.GetPause();
                for (; pause > 0; pause--)
                {
                    Console.Write("Ходит игрок {0}. Осталось времени подумать: {1}\r", game.GetNameCurrentGamer(), pause);
                    Thread.Sleep(1000);
                }
                Console.Write("                                                                                      \r");
                Console.Write("Назовите город: ");
                string city = Console.ReadLine();
                bool end = false;
                if (!game.SearchCity(city))
                {
                    Console.WriteLine("Такого города нет!");
                    end = true;
                }
                else
                {
                    game.NextGamer();
                }
                if (end)
                {
                    Console.WriteLine("Игрок {0} проиграл!", game.GetNameCurrentGamer());
                    Console.ReadKey();
                    return;
                }
            }
            else
                Console.WriteLine("Не найден файл со списком городов!");
            Console.ReadKey();
        }
    }
}
