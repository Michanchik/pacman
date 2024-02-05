using System.Runtime.CompilerServices;



namespace CSharp
{

    internal class Program
    {


        static void Main(string[] args)
        {
            char[,] map = ReadMap("map.txt");

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                DrawMap(map);


                Console.ForegroundColor = ConsoleColor.Yellow;


                Console.SetCursorPosition(1, 1);
                Console.Write("@");

                Thread.Sleep(1000);
            } 

    
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[file[0].Length, file.Length];

            for(int x = 0; x < map.GetLength(0); x++)
                for(int y = 0; y < map.GetLength(0); y++)
                    map[x, y] = file[x][y];

            return map;
        
        } 


        private static void DrawMap(char[,] map)
        {   
            for(int y = 0; y < map.GetLength(0); y++)
                for(int x = 0; x < map.GetLength(0); x++)
                {                    
                    Console.Write(map [x, y]);
                }
                Console.WriteLine();
        }  
    }

}



