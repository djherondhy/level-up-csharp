﻿using System.Text.Json.Serialization;

namespace Comex.Models;

internal class Produto {
    public Produto(string nome) {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }

    [JsonPropertyName("description")]
    public string Descricao { get; set; }

    [JsonPropertyName("price")]
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}