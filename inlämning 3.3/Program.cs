using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" hur många timmar vill du hyra bilen");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;
            if (kostnad > 950) 
            {
                kostnad = 950;

            }
            Console.WriteLine($" kostnade för bilen är i {timmar} timmar är {kostnad} kr ");
            Console.ReadKey();
                
         }
    }
    
}


