class Motocicleta : Veiculo
{
    public string Transmissao { get; set; }
    public int PotenciaMotor { get; set; }

    public string ResumoMotocicleta => $"Marca: {Marca.ToUpper()}\nModelo: {Modelo.ToUpper()}\nAno de fabricacao: {AnoFabricacao}\nPreco: {Preco:c}\nTransmissao: {Transmissao}\nPotencia: {PotenciaMotor}";
}