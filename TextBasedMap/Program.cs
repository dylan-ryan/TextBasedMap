using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedMap
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };
       
        static char[,] border = new char[,]
    {
    
    };
    
        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees


        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays");
            Console.WriteLine();

            DisplayMap(2);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void DisplayMap()
        {
            DisplayMap(0);
        }

        static void DisplayMap(int scale)
        {
            int height = map.GetLength(0);
            int width = map.GetLength(1);

            Console.Write("+");
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j <= scale; j++)
                {
                    Console.Write("-");
                }
            }
            Console.Write("+");
            Console.WriteLine();


            for (int y = 0; y < height; y++)
            {
                for (int w = 0; w <= scale; w++)
                {
                    Console.Write('|');
                    for (int x = 0; x < width; x++)
                    {
                        for (int z = 0; z <= scale; z++)
                        {
                            Console.Write(map[y, x]);
                        }
                    }
                    Console.Write('|');
                    Console.WriteLine();
                }
            }

            Console.Write("+");
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j <= scale; j++)
                {
                    Console.Write("-");
                }
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}
