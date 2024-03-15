using System;

namespace GitCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");

            int num = 0;
           while (true)
            {
                Console.WriteLine("Välj i menyn (ett heltal)");
                num = int .Parse(Console.ReadLine());
                if (num == 1) 
                { 
                    Greetings();
                }

                else if (num == 2)
                {
                    Edvin();
                }
            }
        }

        static void Greetings()
        {
            Console.WriteLine("Tjo tjo från GitCode");
            
        }
        static void Edvin()
        {
               Console.WriteLine("Edvin");
        }
    }
}