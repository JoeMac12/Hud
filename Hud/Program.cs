using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Hud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");

            Console.WriteLine("-----------");

            // declaring "score" variable to be an "interger" type
            // integer = 1, 2, 3
            // float = 0.5, 0.7, 11.6

            int score;
            int enemyValue;
            string name;
            string othername;
            float precentile;

            score = 0;
            enemyValue = 200;
            name = "playername";
            othername = "secondplayer";
            //precentile = 85.453f; 
           

            score = score + enemyValue;
            precentile = (94565.0f / 4234534.0f) * 100.0f;
            //score += enemyValue;

            // hud

            Console.WriteLine(name + " " + othername);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Prectile rank" + " " + precentile + "%");    

            Console.ReadKey(true);
        }
    }
}
