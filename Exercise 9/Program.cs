using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise7;

namespace Exercise_9
{
    class Program
    {
        static Register register = new Register();
        static Logger logger = new Logger();
        Employee anställd = new Employee();
        static void LäggaTillAnställd()
        {
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Social Security Number: ");
            int ssn = int.Parse(Console.ReadLine());
            Console.Write("Hourly Wage:");
            string wage = (Console.ReadLine());
            Employee NyAnställd = new Employee(firstname, lastname, ssn, wage);// konstruktor i employee
            register.LäggaTill(NyAnställd);
            logger.Log("");
        }
        public static void TaBortAnställd()
        {
            Console.WriteLine("Tabort anställd");
            Console.Write("Skriv in social security number: ");
            int ssn = int.Parse(Console.ReadLine());
            Employee TaBort = new Employee(ssn);
            register.RemoveEmploy(ssn);
        }
        static void Main(string[] args)
        {
            int val = 0;
            
            Employee anställd = new Employee();
            
            while (val != 4)
            {
                Console.WriteLine("1. Add employee ");
                Console.WriteLine("2. Remove employee ");
                Console.WriteLine("3. Print entire registry");
                Console.WriteLine("4. Exit");
                val = int.Parse(Console.ReadLine());
                Console.WriteLine("Du valde: "+val);
                Console.ReadKey();
                Console.Clear();

                switch (val)
                {
                    case 1:
                        {
                            LäggaTillAnställd();
                            break;
                        }
                    case 2:
                        {

                            TaBortAnställd();
                            break;
                        }
                    case 3:
                        {
                            register.SkrivUtLista();
                            Console.ReadKey();
                            
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Tack för besöket! Välkommen åter!");
                            break;
                        }
                }
            }


        }
    }
}
