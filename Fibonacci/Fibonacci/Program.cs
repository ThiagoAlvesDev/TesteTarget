namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 0, b = 1;
            bool pertence = false;

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)  pertence = false;
           

            while (a <= n)
            {
                if (a == n)
                {
                    pertence = true;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }


            if (pertence == true)
            {
                Console.WriteLine($"\nO número {n} pertence à sequência Fibonacci. ");

            }
            else
            {
                Console.WriteLine($"\nO número {n} não  pertence à sequência Fibonacci. ");

            }

            Console.Read();
        }
    }
}
