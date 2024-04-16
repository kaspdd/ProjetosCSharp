class Helicoptero : Veiculo
{
    public int CapacidadeDePessoas { get; set; }
    public double Carga { get; set; }

    public string ResumoHelicoptero => $"Marca: {Marca.ToUpper()}\nModelo: {Modelo.ToUpper()}\nAno de fabricacao: {AnoFabricacao}\nPreco: {Preco:c}\nCapacidade de pessoas suportada: {CapacidadeDePessoas}\nCarga: {Carga:f2}";
}