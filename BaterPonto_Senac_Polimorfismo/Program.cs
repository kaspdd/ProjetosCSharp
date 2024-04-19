// See https://aka.ms/new-console-template for more information
using BaterPonto.Modelos;

public class Program
{
    public static void Main(string[] args)
    {   
        
        Funcionario carlos = new Funcionario("Carlos");
       
        carlos.RegistrarEntrada(carlos); 

    }
}

