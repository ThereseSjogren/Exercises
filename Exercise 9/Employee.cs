using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Employee
    {
        //private string namn; variabel
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int SSN{ get; set; }
        public string Wage{ get; set; }//Hourly Wage=Timlön
        
        public string FullName
        {
            get
            {
                return FirstName +" "+ LastName;
            }
        }
        public string HelaAnställd
        {
            get
            {
                return "Namn: " + FirstName + " " + LastName+" "+ "Social Security Number: " + SSN+" "+ "Hourly Wage: " + Wage;
                //return FirstName + " " + LastName + SSN +Wage;

            }
        }

        public Employee()//tom konstruktor
        {

        }
        public Employee(string firstname, string lastname, int ssn, string wage)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.SSN = ssn;
            this.Wage = wage;

        }

        public Employee(int ssn)
        {

        }
        public void SkrivUtAnställd()
        {
            Console.WriteLine("Namn: "+FirstName+" "+LastName);
            Console.WriteLine("Social Security Number: "+SSN);
            Console.WriteLine("Hourly Wage: "+Wage);
        }
        
        //public string GetNamn() Detta används om variablern är private
        //{
        //    return namn;
        //}

        //public void SättNamn(string namn)
        //{
        //    this.namn = namn;
        //}


    }
}
