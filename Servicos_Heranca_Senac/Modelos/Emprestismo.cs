namespace Servicos.Modelos;

class Emprestimo : Servico
{
    public Emprestimo(double valor, string contratante)
    {
        Valor = valor;
        Contratante = contratante;
        
    }   

    public double Valor { get; set; }
    public double Taxa { get; set; }

    public string ResumoEmprestimo => $"Valor solicitado: {Valor:c}\nTaxa ";

    public string Parcelar ()
    {
        string valorParcela = "";
        double pacela = 0;
        if (Valor >=1000 && Valor <= 5000)
        {
            Taxa = Valor*1.28;
            pacela = Taxa/12;
            valorParcela = $"o valor de {Valor:c} com a taxa de 28% ficou o total de {Taxa:c}\nE divido em 12 vezes, cada parcela ficou em: {pacela:c}";
        }
        else if (Valor > 5000 && Valor <= 10000)
        {
            Taxa = Valor*1.52;
            pacela = Taxa/24;
            valorParcela = $"o valor de {Valor:c} com a taxa de 52% ficou o total de {Taxa:c}\nE divido em 12 vezes, cada parcela ficou em: {pacela:c}";
        }
        else if(Valor >10000 && Valor <= 20000)
        {
            Taxa = Valor*1.68;
            pacela = Taxa/48;
            valorParcela = $"o valor de {Valor:c} com a taxa de 68% ficou o total de {Taxa:c}\nE divido em 12 vezes, cada parcela ficou em: {pacela:c}";
        }
        else
        {
            valorParcela = "Valor fora dos limites";
        }
        return valorParcela;
    }

}