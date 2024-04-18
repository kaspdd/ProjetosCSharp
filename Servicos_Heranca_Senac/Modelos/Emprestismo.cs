namespace Servicos.Modelos;

public class Emprestimo : Servico
{
    public Emprestimo(double valor, string contratante)
    {
        Valor = valor;
        Contratante = contratante;
        
    }   

    public double Valor { get; set; }
    public double Taxa { get; set; }

    public double Total { get; set; }
    public double Parcela  { get; set; } 

    public double QuantidadeParcela { get; set; }


    public string ResumoEmprestimo => $"Valor solicitado: {Valor:c}\nTaxa ";

    public string Parcelar ()
    {
        string mensagemParcela = "";
        string valorTaxa = "";
        if (Valor >=1000 && Valor <= 5000)
        {
            Taxa = 0.28;
            Total = Valor+(Valor*Taxa);
            QuantidadeParcela = 12;
            Parcela = Total/QuantidadeParcela;
            valorTaxa = "28%";
            
        }
        else if (Valor > 5000 && Valor <= 10000)
        {
            Taxa = 0.52;
            Total = Valor+(Valor*Taxa);
            QuantidadeParcela = 24;
            Parcela = Total/QuantidadeParcela;
            valorTaxa = "52%";
        }
        else if(Valor > 10000 && Valor <= 20000)
        {
            Taxa = 0.68;
            Total = Valor+(Valor*Taxa);
            QuantidadeParcela = 48;
            Parcela = Total/QuantidadeParcela;
            valorTaxa = "68%";
        }
        else
        {
            mensagemParcela = "Valor fora dos limites";
        }
        mensagemParcela = $"o valor de {Valor:c} com a taxa de {valorTaxa} ficou o total de {Total:c}\nE divido em 48 vezes, cada parcela ficou em: {Parcela:c}";
        return mensagemParcela;
    }

}