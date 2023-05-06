namespace Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 1;

            while(option == 1)
            {
                Console.WriteLine("Say me a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                option = 0;
                if (number % 2 == 0)
                {
                    Console.WriteLine($"\nThe number {number} is even!\n");
                }
                else
                {
                    Console.WriteLine($"\nThe number {number} is odd!\n");
                }

                Console.WriteLine("\nWould you like to see another number?If so, please type 1");
                option = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}