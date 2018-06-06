using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy;

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Write("Enter distance (try: 300, 200, 100): ");
                int distance = Convert.ToInt32(Console.ReadLine());

                enemy = new Enemy(distance);

                //Console.Write("Enemy current state: " + enemy.GetEnemyCurrentState() + "\n");
            }
        }
    }
}
