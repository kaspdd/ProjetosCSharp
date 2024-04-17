namespace Servicos.Modelos;

class Emprestimo : Servico
{
    public Emprestimo(double valor)
    {
        Valor = valor;
    }   

    public double Valor { get; set; }
    public double Taxa { get; set; }

    public string ResumoEmprestimo => $"Valor solicitado: {Valor:c}\nTaxa ";

    public string Parcelar ()
    {
        string valorParcela = "";
        double total = 0;
        if (Valor >=1000 && Valor <= 5000)
        {
            Taxa = 1.28;
            total = (Valor*Taxa)/12;
            valorParcela = $"o valor de {Valor} parcelado em 12 vezes ficou no total de {total:c}";
        }
        else if (Valor > 5000 && Valor <= 10000)
        {
            Taxa = 1.58;
            total = (Valor*Taxa)/24;
            valorParcela = $"o valor de {Valor} parcelado em 24 vezes ficou no total de {total:c}";
        }
        else if(Valor >10000 && Valor <= 20000)
        {
            Taxa = 1.68;
            total = (Valor*Taxa)/48;
            valorParcela = $"o valor de {Valor} parcelado em 48 vezes ficou no total de {total:c}";
        }
        else
        {
            Console.WriteLine("Valor fora dos limites");
        }
        return valorParcela;
    }

}