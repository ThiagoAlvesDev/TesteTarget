namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um palavra: ");
            string palavra = Console.ReadLine();

            char[] caracteres = palavra.ToCharArray();
            string palavraInvertida = string.Empty;

            for(int i = caracteres.Length - 1; i >= 0; i--)
            {
                palavraInvertida += caracteres[i];
            }

            Console.WriteLine($"Palavra invertida: {palavraInvertida}");
            Console.Read();
        }
    }
}
