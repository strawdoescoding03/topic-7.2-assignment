namespace topic_7._2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name;

            int displayCount = 5;

            //Task One


            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }

            Console.WriteLine("Blast Off");



            //Task Two

            Console.WriteLine("\t x \t |\t y \t\t");
            Console.WriteLine("====================================");

            for (int i = -10; i <= 10; i = (2 + i))

            {
                Console.WriteLine("        " + i + "\t | \t" + (i * i));
            }


            //Task Three


            Console.WriteLine("Please enter your name!");

            name = Console.ReadLine().ToLower();

            if (name != "aldworth")
            {
                displayCount = 10;
            }


            for (int i = 1; i <= displayCount; i++)
            {
                Console.WriteLine(name);
            }



        }
    }
}
