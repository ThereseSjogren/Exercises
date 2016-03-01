using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class LogApplication
    {

        ILogger _logger;
        public LogApplication(ILogger logger)
        {
            this._logger = logger;
        }
        public void Run()
        {
            //Console.WriteLine("1. Add message to log");
            //Console.WriteLine("2. Print log");
            //Console.WriteLine("3. Quit");
            //int choice = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("1. Add message to log");
                Console.WriteLine("2. Print log");
                Console.WriteLine("3. Quit");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Choice: " + choice);

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Write the message: ");
                            var message = Console.ReadLine();
                            _logger.Log(message);
                            break;
                        }
                    case 2:
                        {
                            foreach (var message in _logger.LogPosts)
                            {
                                Console.WriteLine(message);
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Bye Bye");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }


        }
    }
}
