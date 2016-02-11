
class Conta
{
    public virtual void Saque(string agencia, string conta, double valor)
    {
        System.Console.WriteLine("Saque, Ag.: {0} C/C.: {1} Valor R$ {2:00}", agencia,conta,valor);
    }
}

