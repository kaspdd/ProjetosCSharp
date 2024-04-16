class Automovel : Veiculo
{
    public int RodasAro { get; set; }  
    public string Cambio { get; set; }

    public string ResumoAutomovel => $"Marca: {Marca.ToUpper()}\nModelo: {Modelo.ToUpper()}\nAno de fabricacao: {AnoFabricacao}\nPreco: {Preco:c}\nAro da roda: {RodasAro}\nCambio: {Cambio}";



}