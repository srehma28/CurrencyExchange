
namespace Exchange
{
    class Program
    {
        public static void Main()
        {

            double EUR, USD, AUD, choice, GBP;

            double euroRate = 1.11;
            double dollarRate = 1.68;
            double australianDollarRate = 0.60;

            Console.WriteLine("Saqib Currency Exchange");
            Console.WriteLine("Enter your Choice :\n 1- GBP to EUR \n 2- GBP to USD \n 3- GBP to AUD ");
            while (!double.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }


            switch (choice)
            {
                case 1:
                    Console.Write("Enter the GBP Amount :");
                    while (!double.TryParse(Console.ReadLine(), out GBP))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                    }
                    EUR = GBP * euroRate;
                    Console.WriteLine("{0} GBP Equals {1} EUR", GBP, EUR);
                    break;
                case 2:
                    Console.Write("Enter the GBP Amount :");
                    while (!double.TryParse(Console.ReadLine(), out GBP))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                    }
                    USD = GBP * dollarRate;
                    Console.WriteLine("{0} GBP Equals {1} USD", GBP, USD);
                    break;
                case 3:
                    Console.Write("Enter the GBP Amount :");
                    while (!double.TryParse(Console.ReadLine(), out GBP))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                    };
                    AUD = GBP * australianDollarRate;
                    Console.WriteLine("{0} GBP Equals {1} AUD", GBP, AUD);
                    break;
            }
            Console.WriteLine("Thank you");
        }
    }
}