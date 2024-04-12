namespace GitCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Samarbetsappen");
            int run = 0;
            while (true)
            {
                Console.WriteLine("Välj i menyn (ett heltal)");
                run = int.Parse(Console.ReadLine());
                if (run == 1)
                {
                    Greetings();
                }
                else if (run == 2)
                {
                    Counter();
                }
                else
                {
                    Console.WriteLine("Hej då");
                    break;
                }
            }
        }
        static void Greetings()
        {
            Console.WriteLine("Hello from GitCode");
        }
        static void Counter()
        {
            for (int i = 0; i < 10; i++) {
                Console.Write(i + "");
            }
            Console.WriteLine("Slut på uppräkningen")
        }
    }
}