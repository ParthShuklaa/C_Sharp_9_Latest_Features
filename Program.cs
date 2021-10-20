using System;

namespace Looping_Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();

            Console.Write("How many times you want to Display Your name ");
            int Count = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Name);

            }

            

            //Entry Controlled loop
            //While()
            //Exit Controlled loop
            //Dowhile()
        }
    }
}
