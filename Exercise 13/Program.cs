using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menyn
            Console.WriteLine("Write your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Write the year you were born: ");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the month you were born: ");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the day you were born: ");
            var day = int.Parse(Console.ReadLine());

            //DateTime variabler
            var myAge = DateTime.Now.Year - year;
            DateTime Mydate = new DateTime(year, month, day);
            DateTime currentDay = DateTime.Today;
            DateTime recentbirthday = Mydate.AddYears(myAge);
            TimeSpan untilmynextBirthDay =recentbirthday -currentDay;

            //Kollar om jag har fyllt år eller inte detta året
            if (Mydate.DayOfYear<=DateTime.Now.DayOfYear)
            {
                Console.WriteLine("My Age:"+myAge);
            }
            else
            {
                myAge-=1;
                Console.WriteLine("My Age:" + myAge);
            }


            //If sats som kollar hur långt det är kvar till nästa födelsedag
            int daysuntilNextBirthday = 0;
            if (untilmynextBirthDay.Days<0)//If sats som kollar hur många dagar det är kvar till jag fyller år
            {
                daysuntilNextBirthday = untilmynextBirthDay.Days + 365;
            }
            else
            {
                daysuntilNextBirthday = untilmynextBirthDay.Days;
            }

            
            var untilimhundred = 100 - myAge;
            DateTime myHundred = Mydate.AddYears(100);
            Console.WriteLine($"Hello, {name}. You are {myAge} years old, and will turn {myAge+1} in {daysuntilNextBirthday} days.\nYour 100th birthday will be on a {myHundred.DayOfWeek}");
            Console.ReadKey();
            



        }
    }
}
