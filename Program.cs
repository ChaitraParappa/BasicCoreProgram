namespace BasicCoreProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select the option which program you want to exceute");
           
            int option = Convert.ToInt32(Console.ReadLine());

           

            switch(option)
            {
               
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }
        }
    }
}
