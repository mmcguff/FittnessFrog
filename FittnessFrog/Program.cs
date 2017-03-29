using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FittnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new Program();
            start.RunProgram();

        }

        public void RunProgram()
        {
            string smin = "0";
            int total = 0;
           
            //Repeat until User quits
            while (smin != "x")
            {
                total = total + Convert.ToInt32(smin);
                //Prompt user for minutes exercised
                Console.WriteLine("How many mintues did you exercise?  Enter 'x' to Stop.");

                //Add minutes exercised to total
                smin = Console.ReadLine();
                
            }

            //Display total minutes exercised to the screen
            Console.WriteLine("You exercised " + total + " minutes.");

            Console.ReadKey();
        }

        

    }
}
