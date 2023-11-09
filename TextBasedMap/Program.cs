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
        {'▓','▓','▓','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
        {'▓','▓','░','░','░','░','▒','▒','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','≡','≡','≡','░','░','░'},
        {'▓','▓','░','░','░','▒','▒','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','≡','≡','≡','░','░','░','░','░'},
        {'▓','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
        {'░','░','░','░','≡','≡','≡','░','░','░','░','░','░','▒','▒','▒','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
        {'░','░','░','░','≡','≡','≡','░','░','░','░','░','░','▒','▒','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
        {'░','░','░','≡','≡','≡','≡','░','░','░','░','░','▒','▒','░','░','░','░','░','░','░','░','▓','▓','░','░','░','░','░','░'},
        {'░','░','░','░','░','≡','≡','≡','░','░','░','░','░','░','░','░','░','░','░','░','░','▓','▓','▓','▓','░','░','░','░','░'},
        {'░','░','░','░','░','≡','≡','≡','≡','░','░','░','░','░','░','░','░','░','░','░','░','░','░','▓','▓','▓','▓','░','░','░'},
        {'░','░','░','░','░','░','░','≡','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
        {'░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
        {'░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░','░'},
    };
       
        static char[,] border = new char[,]
    {
    
    };

        // usage: map[y, x]

        // map legend:
        // ▓ = mountain
        // ░ = grass
        // ≡ = water
        // ▒ = trees


        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays");
            Console.WriteLine();
            Console.WriteLine("Map Legend:");
            Console.WriteLine("≡ = Water");
            Console.WriteLine("░ = Grass");
            Console.WriteLine("▒ = Trees");
            Console.WriteLine("▓ = Mountains");
            Console.WriteLine();

            Console.WriteLine("This is what DisplayMap() looks like:");
            DisplayMap();
            Console.WriteLine("This is what DisplayMap(0) looks like:");
            DisplayMap(0);
            Console.WriteLine("This is what DisplayMap(1) looks like:");
            DisplayMap(1);
            Console.WriteLine("This is what DisplayMap(2) looks like:");
            DisplayMap(2);
            Console.WriteLine("This is what DisplayMap(3) looks like:");
            DisplayMap(3);
            Console.WriteLine("Etc...");

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

            Console.Write("╔");
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j <= scale; j++)
                {
                    Console.Write("═");
                }
            }
            Console.Write("╗");
            Console.WriteLine();


            for (int y = 0; y < height; y++)
            {
                for (int w = 0; w <= scale; w++)
                {

                    Console.Write('║');
                    for (int x = 0; x < width; x++)
                    {
                        for (int z = 0; z <= scale; z++)
                        {
                            Console.Write(map[y, x]);
                        }
                    }
                    Console.Write('║');
                    Console.WriteLine();

                }
            }

            
            Console.Write("╚");
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j <= scale; j++)
                {
                    Console.Write("═");
                }
            }
            Console.Write("╝");
            Console.WriteLine();

        }
    }
}
