namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\nAnd how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nHello, {name}!\nI see that you are {age} years old! That's so cool!");
        }
    }
}