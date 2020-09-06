using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            M: Console.WriteLine("Enter the date to define the day of the week: ");
            String userDate = Console.ReadLine();
            bool result = DateTime.TryParse(userDate, out DateTime date);
            if (result)
            {
                Console.WriteLine(date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Date entered incorrectly, try one more time");
                goto M;
            }
        }
    }
}
