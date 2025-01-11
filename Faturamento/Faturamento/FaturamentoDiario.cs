using System;
using System.Text.Json.Serialization;

public class FaturamentoDiario
{
    [JsonPropertyName("dia")]
    public int Dia { get; set; }

    [JsonPropertyName("valor")]
    public double Valor { get; set; }
}
