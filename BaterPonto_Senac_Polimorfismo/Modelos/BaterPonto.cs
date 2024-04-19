using System.Data.Common;

namespace BaterPonto.Modelos;

public class BaterPonto 
{
    public BaterPonto()
    {

    }
    public string Agora => DateTime.Now.ToString("dd/MM/yyyy");
    //public bool Ponto { get; set; }


    public void RegistrarEntrada(Funcionario funcionario)
    {
        Console.WriteLine($"Entrada Registrada!\nData de entrada: {Agora}");
            
    }

    
    public void RegistrarSaida(Funcionario funcionario)
    {
        Console.WriteLine($"Saida Registada!\nData de saida: {Agora}");
        
    }
}

