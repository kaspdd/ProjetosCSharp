namespace Servicos.Modelos;

class SeguroVeiculos : Servico
{
    public SeguroVeiculos(string veiculo, int anoVeiculo, string contratante)
    {
        Veiculo = veiculo;
        AnoVeiculo = anoVeiculo;
        Contratante = contratante;
    }
    public string Veiculo { get; set; }
    public int AnoVeiculo { get; set; }
    public double PrecoSeguro { get; set; }
    public double PrecoFranquia { get; set; }

    public string ResumoSeguro => $"Nome do veiculo: {Veiculo}\nAno do veiculo: {AnoVeiculo}\npreco do veiculo: {PrecoSeguro:c}\nPreco da franquia: {PrecoFranquia:c}\nNome do contratante: {Contratante}\nResponsavel: {Responsavel}\nData do contrato: {DataContrato}\n";


    public string AnoSeguroDeVeiculos()
    {
        string mensagemSeguroDeVida = "";
        if (AnoVeiculo >= 2000 && AnoVeiculo <= 2010)
        {
            mensagemSeguroDeVida = "Voce selecionou: \nSeguro no valor de R$ 18.000,00 e Preco da franquia de R$ 6.000,00";
        }
        else if (AnoVeiculo >= 2011 && AnoVeiculo <= 2020)
        {   
            mensagemSeguroDeVida = $"O ano do veiculo: {AnoVeiculo}\nVoce selecionou: \nSeguro no valor de R$ 48.000,00 e Preco da franquia de R$ 16.000,00";
        }
        else if(AnoVeiculo >= 2021 && AnoVeiculo <= 2024)
        {
            mensagemSeguroDeVida = $"O ano do veiculo: {AnoVeiculo}\nVoce selecionou: \nSeguro no valor de R$ 66.000,00 e Preco da franquia de R$ 22.000,00";
        }
        else
        {
            mensagemSeguroDeVida = $"O ano {AnoVeiculo} nao esta dentro do periodo cadastrado, por favor digitar um ano entre 2000 a 2024.";
        }
        return mensagemSeguroDeVida;	
    }
}