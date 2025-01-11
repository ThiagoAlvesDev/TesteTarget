using System.Text.Json;

namespace Faturamento
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FaturamentoDiario.json");

                string jsonData = File.ReadAllText(jsonPath);

                List<FaturamentoDiario> faturamento = JsonSerializer.Deserialize<List<FaturamentoDiario>>(jsonData);

                var diasComFaturamento = faturamento.Where(f => f.Valor > 0).ToList();

                double menorFaturamento = diasComFaturamento.Min(m => m.Valor);

                double maiorFaturamento = diasComFaturamento.Max(m => m.Valor);

                double somaFaturamento = diasComFaturamento.Sum(s => s.Valor);
                double mediaMensal = somaFaturamento / diasComFaturamento.Count();

                int diasAcimaMedia = diasComFaturamento.Count(m => m.Valor > mediaMensal);



                Console.WriteLine($"Menor valor de faturamento: R$ {menorFaturamento:F2}");
                Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento:F2}");
                Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaMedia}");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ao processar o arquivo JSON.");
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
