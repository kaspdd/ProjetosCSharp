namespace Servicos.Modelos;

class SeguroVeiculos : Servico
{
    public SeguroVeiculos(string veiculo, int anoVeiculo, double precoSeguro, double precoFranquia)
    {
        Veiculo = veiculo;
        AnoVeiculo = anoVeiculo;
        PrecoSeguro = precoSeguro;
        PrecoFranquia = precoFranquia;
        
    }
    public string Veiculo { get; set; }
    public int AnoVeiculo { get; set; }
    public double PrecoSeguro { get; set; }
    public double PrecoFranquia { get; set; }

    public string ResumoSeguro => $"Nome do veiculo: {Veiculo}\nAno do veiculo: {AnoVeiculo}\npreco do veiculo: {PrecoVeiculo:c}\nPreco da franquia: {PrecoFranquia:c}\nNome do contratante: {Contratante}\nResponsavel: {Responsavel}\nData do contrato: {DataContrato}\n";


    public string AnoSeguroDeVeiculos()
    {
        string mensagemSeguroDeVida = "";
        if (AnoVeiculo >= 2000 && AnoVeiculo <= 2010)
        {
            mensagemSeguroDeVida = $"O ano do veiculo: {AnoVeiculo}\nVoce selecionou: \nSeguro no valor de {PrecoSeguro}\nPreco da franquia {PrecoFranquia}";
        }
    }
}