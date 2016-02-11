
class Corrente: Conta
{
    public override void Saque(string agencia, string conta, double valor)
    {
        valor = valor - (valor * 0.10);
        base.Saque(agencia, conta, valor);
    }
}

