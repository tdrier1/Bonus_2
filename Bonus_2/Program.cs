using System;


namespace Bonus_2
{
    class AgeCalc
    {
        static void Main(string[] args)
        {
            DateTime date1;

            Console.Write("How long have you been alive?");

            Console.Write("\n");
            Console.Write("\n");

            Console.Write("Please enter your Birthday: ");
            while(!DateTime.TryParse(Console.ReadLine(), out date1))
            {
                Console.Write("Please enter a vaid date! ");
                
            }
            
            DateTime date2 = DateTime.Now;

            TimeSpan difference = date2 - date1;

            var time = difference.TotalDays;

            int value = Convert.ToInt32(time);

            int years = (value / 365);
            int days = (value % 365);

            Console.WriteLine("\n");
            Console.WriteLine("You are {0} years and {1} days old!" , years, days);

            string s1 = Convert.ToDateTime(date1).ToString("MM/dd");
            string s2 = Convert.ToDateTime(date2).ToString("MM/dd");

            if (s1==s2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Happy Birthday!");
            }

            Console.ReadKey();



        }
    }
}
