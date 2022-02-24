using System;
namespace HelloWorld
{
    class Assignment
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly ilaro ";

            Console.Write("Enter second Integer: ");
            int sam_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second double: ");
            double sam_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second string: ");
            string sam_str = Console.ReadLine();

            Console.WriteLine(i + sam_int);
            Console.WriteLine(d + sam_double);
            Console.WriteLine(s + sam_str);
            

            
        }
    }
}