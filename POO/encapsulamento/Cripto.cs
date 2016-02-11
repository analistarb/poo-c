
class Cripto
{
    private string valor;

    public void setValor(string texto)
    { 
        valor = texto.Replace('a','1');
    }

    public string getValor()
    {
        return valor;
    }

}

