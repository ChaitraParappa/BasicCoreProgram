namespace BasicCoreProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select the option which program you want to exceute");
            Console.WriteLine("Option 1 : Flip the Coin");
            int option = Convert.ToInt32(Console.ReadLine());

           

            switch(option)
            {
                case 1:
                    FlipCoin.CalculatePercentage();
                    break;
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }
        }
    }
}
