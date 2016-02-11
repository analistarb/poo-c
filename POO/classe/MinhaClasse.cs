
class MinhaClasse
{
    public MinhaClasse()
    {
        Telefone meuTelefone = new Telefone("Preto","WP7");
        meuTelefone.Ligar("9999-9999");
        meuTelefone.Ligar("011","9999-9999");
    }

}

class Telefone
{
    private string cor;
    private string SO;

    public Telefone(string _cor, string _SO) 
    {
        cor = _cor;
        SO = _SO;
    }

    public void Ligar(string numeroDiscar)
    {
        string texto = BemVindo();
        System.Console.WriteLine(texto);
        System.Console.WriteLine("Ligando para {0}",numeroDiscar);    
    }


    public void Ligar(string ddd, string numeroDiscar)
    {
        string texto = BemVindo();
        System.Console.WriteLine(texto);
        System.Console.WriteLine("Ligando para {0} - {1}",ddd, numeroDiscar);
    }

    private string BemVindo() 
    {
        string texto = "Telefone " + cor + " com o sistema operacional " + SO;
        return texto;
    }

    public static void Discar(string numeroDiscar)
    {
        System.Console.WriteLine("Ligando para {0}",numeroDiscar);
    }


    ~Telefone()
    {
        System.Console.WriteLine("Telefone sendo liberado da memoria");
    }
}

