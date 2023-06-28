using System.Dynamic;

namespace MonthNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Month To Check Days as per serial no");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("31 Days in January");
            }
            else if (a == 2)
            {
                Console.WriteLine("28 Days in February");
            }
            else if (a == 3)
            {
                Console.WriteLine("31 Days in March");
            }
            else if (a == 4)
            {
                Console.WriteLine("30 Days in April");
            }
            else if (a == 5)
            {
                Console.WriteLine("31 Days in May");
            }
            else if (a == 6)
            {
                Console.WriteLine("30 Days in June");
            }
            if (a == 7)
            {
                Console.WriteLine("31 Days in July");
            }
            if (a == 8)
            {
                Console.WriteLine("31 Days in August");
            }
            if (a == 9)
            {
                Console.WriteLine("30 Days in September");
            }
            if (a == 10)
            {
                Console.WriteLine("31 Days in Octember");
            }
            if (a == 11)
            {
                Console.WriteLine("30 Days in November");
            }
            else if (a == 12)
            {
                Console.WriteLine("31 Days in December");
            }
            if (a >= 13)
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}