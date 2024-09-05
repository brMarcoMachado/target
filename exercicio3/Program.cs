//Utilizei a biblioteca Newtonsoft.Json para manipulação de JSON
using Newtonsoft.Json;

class Program
{
    class FaturamentoDiario
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        // Lê o arquivo JSON
        string jsonFile = "dados.json";
        string jsonData = File.ReadAllText(jsonFile);

        // Converte o JSON para uma lista de objetos
        List<FaturamentoDiario> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(jsonData);

        // Remove os dias com faturamento zero (finais de semana e feriados)
        List<FaturamentoDiario> diasValidos = faturamentos.Where(f => f.valor > 0).ToList();

        if (diasValidos.Count == 0)
        {
            Console.WriteLine("Não há dias com faturamento válido.");
            return;
        }

        // Calcula o menor e maior faturamento
        double menorFaturamento = diasValidos.Min(f => f.valor);
        double maiorFaturamento = diasValidos.Max(f => f.valor);

        // Calcula a média mensal de faturamento (apenas dias com faturamento válido)
        double mediaFaturamento = diasValidos.Average(f => f.valor);

        // Conta o número de dias com faturamento acima da média
        int diasAcimaDaMedia = diasValidos.Count(f => f.valor > mediaFaturamento);

        // Exibe os resultados
        Console.WriteLine($"Menor faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
