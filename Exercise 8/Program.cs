using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");
            

            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
