using System.Security.Cryptography.X509Certificates;

namespace BaterPonto.Modelos;

internal class Setor
{

    public int IdSetor { get; set; }
    public string NomeSetor { get; set; }
    

    public void TabelaSetor()
    {
        var rows = 4;
        var cols = 2;
        string[,] setores = new string[rows, cols];
        setores[0,0] = "IdSetor"; setores[0,1] = "NomeSetor";
        setores[1,0] = "   1"; setores[1,1] = "Administrativo";
        setores[2,0] = "   2"; setores[2,1] = "Proucao";
        setores[3,0] = "   3"; setores[3,1] = "Comercial";
        
        Console.WriteLine($"Segue a Lista de setores:");
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{setores[i,j]}\t");
                
            }
            Console.WriteLine($"");
            
        }

    }





}