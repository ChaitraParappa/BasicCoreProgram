namespace BasicCoreProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select the option which program you want to exceute");
            Console.WriteLine("Option 1 : Flip the Coin");
            Console.WriteLine("Option 2 : QuotientRemaider");
            int option = Convert.ToInt32(Console.ReadLine());

           

            switch(option)
            {
                case 1:
                    FlipCoin.CalculatePercentage();
                    break;
                case 2:
                    QuotientRemainder.CalculateQuotientAndRemainder();
                    break;
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }
        }
    }
}
