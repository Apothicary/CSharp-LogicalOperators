namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Logical Operators can be used to check if more than one condition is true/false

            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)           // An example of an AND operator 
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >=50)      // An example of an OR operator 
            {
                Console.WriteLine("Do not go outside!");
            }

            Console.ReadKey();
        }
    }
}
