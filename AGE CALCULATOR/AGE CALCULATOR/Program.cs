using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGE_CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO AGE CALCULATOR");
            Console.WriteLine("Enter Your Date Of Birth in DD/MM/YYYY format");
            string db = Console.ReadLine();
            DateTime dob = Convert.ToDateTime(db);
            DateTime today = DateTime.Now;
            int agey = today.Year - dob.Year;
            int agem = today.Month - dob.Month;
            int aged = today.Day - dob.Day;
            if (aged < 0)
            {
                agem = agem - 1;
            }
            if (agem < 0)
            {
                agey = agey - 1;
            }
            if (agem < 0)
            {
                agem = 12 + agem;
            }
            if (aged < 0)
            {
                aged = 31 + today.Day - dob.Day;
            }
            else
            {
                agey = today.Year - dob.Year;
                agem = today.Month - dob.Month;
                aged = today.Day - dob.Day;
            }
            if (agey < 0)
            {
                Console.WriteLine("Date of birth needs to be earlier than the age at date.");
            }
            else
            {

                Console.WriteLine("Your Age Is : " + agey + " " + "Years" + " " + agem + " " + "Months" + " " + aged + " " + "Days");
            }
            Console.ReadLine();
        }
    }
}
