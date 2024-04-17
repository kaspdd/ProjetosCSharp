namespace Servicos.Modelos;

class Servico
{
    public string Contratante {get; set;}
    public string Responsavel => "Sistema - via aplicativo";
    public string DataContrato => DateTime.Now.ToString("dd-MM-yyyy");

}