using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise7;

namespace Exercise_9
{
    class Register
    {
        
        public List<Employee>ListaPåAnställda{ get; set; }

        public Register()//konstruktor
        {
            ListaPåAnställda = new List<Employee>();
        }
        public void LäggaTill(Employee läggtill)//Metod för att lägga till på listan
        {
            ListaPåAnställda.Add(läggtill);
           
        }
        public void TaBort(Employee tabort)//Metod för att ta bort
        {
            ListaPåAnställda.Remove(tabort);
        }
        public void SkrivUtLista()//Metod för att skriva ut från listan
        {
            foreach (Employee anställd in ListaPåAnställda)
            {

                Console.WriteLine(anställd.HelaAnställd);
                Console.ReadKey();
            }
        }
        public void RemoveEmploy(int ssn)//Metod för att söka igenom listan och ta bort
        {
            for (int i = 0; i < ListaPåAnställda.Count; i++)
            {
                {
                    if(ListaPåAnställda[i].SSN==ssn)
                    {
                        ListaPåAnställda.Remove(ListaPåAnställda[i]);//Kallar på metoden TaBort
                    }
                }
            }
        }
       
    }
}
