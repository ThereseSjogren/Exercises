using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class Game
    {
        private int CountNeighbour(int y, int x, int[,] arr)//Räknar ut hur många grannar som är jämte
        {

            int count = 0;
            try
            {
                if (arr[y - 1, x - 1] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y, x - 1] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y + 1, x - 1] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y + 1, x] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y + 1, x + 1] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y, x + 1] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y - 1, x + 1] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            try
            {
                if (arr[y - 1, x] == 1)
                {
                    count += 1;
                }
            }
            catch
            {

            }
            return count;
        }
        public void PrintVisualGrid(int[,] arr)//Random (slumpar) ut rutnätet "framför" 
        {
            //Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)// Y led
            {
                for (int j = 0; j < arr.GetLength(1); j++)//X led
                {
                    //var newrandom = random.Next(20);//slumpar tal mellan 0 till 20

                    if (arr[i,j] > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        //Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        

                    }
                    if (arr[i,j] == 0)
                    {
                        //Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
            }

        }
        //public void PrintLogicGrid(int[,] arr)//Random (slumpar) ut rutnätet "bakom"
        //{
        //    //Random random = new Random();
        //    for (int i = 0; i < arr.GetLength(0); i++)// Y led
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)//X led
        //        {
        //            //var newrandom = random.Next(20);//slumpar tal mellan 0 till 20

        //            if (arr[i,j] == 0)
        //            {
        //                arr[i, j] = 1;//sätter ur "bakom kulisserna"
        //            }
        //            if (arr[i,j] > 0)
        //            {
        //                arr[i, j] = 0;//sätter ur "bakom kulisserna"
        //            }
        //        }
        //        Console.WriteLine();
        //    }

        //}
        public void ProcessGame(int[,] arr)//kollar om cellen skall leva eller inte genom att kolla hur många grannar den har
        {

            var snapShot = new int[arr.GetLength(0), arr.GetLength(1)];

            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    snapShot[x, y] = arr[x, y];
                }
            }

            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    if (arr[x, y] == 1 && CountNeighbour(x, y, snapShot) < 2)
                    {
                        arr[x, y] = 0;
                    }
                    if (arr[x, y] == 1 && CountNeighbour(x, y, snapShot) > 3)
                    {
                        arr[x, y] = 0;
                    }
                    if (arr[x, y] == 1 && CountNeighbour(x, y, snapShot) == 2 || CountNeighbour(x, y, snapShot) == 3)
                    {
                        arr[x, y] = 1;
                    }
                    if (arr[x, y] == 0 && CountNeighbour(x, y, snapShot) == 3)
                    {
                        arr[x, y] = 1;
                    }
                }
            }


        }
    }
}

