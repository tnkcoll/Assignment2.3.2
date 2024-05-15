namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double billTotal;

            billTotal = GetBillTotal();
            CalculateTax(billTotal);
        }

        public static double GetBillTotal()
        {
            string userInput;

            do
            {
                Console.WriteLine("What was the pre-tax total of the bill?");
                userInput = Console.ReadLine();
            }while (userInput == "");

            return Convert.ToDouble(userInput);
        }
        
        public static void CalculateTax(double total)
        {
            double tip15;
            double tip18;
            double tip20;

            try
            {
                tip15 = total * Convert.ToDouble(.15m);
                tip18 = total * Convert.ToDouble(.18m);
                tip20 = total * Convert.ToDouble(.20m);
                Console.WriteLine("A 15% tip for your bill is: {0:C2}", tip15);
                Console.WriteLine("A 18% tip for your bill is: {0:C2}", tip18);
                Console.WriteLine("A 20% tip for your bill is: {0:C2}", tip20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                
            }
        }
    }
}
