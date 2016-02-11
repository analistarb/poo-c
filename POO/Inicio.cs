//-----------------------------------------------
//Para testar use CTRL + F5
//-----------------------------------------------

class Inicio
{
    static void Main(string[] args)
    {
        //-----------------------------------------------
        //---> Classe <---
        //-----------------------------------------------
        /*
        MinhaClasse mm = new MinhaClasse();
        Telefone.Discar("9999-9999");
        */

        //-----------------------------------------------
        //---> Composição <--- 
        //-----------------------------------------------
        /*
        Roda r1 = new Roda();
        r1.cor = "Azul";
        r1.aro = 22;

        Roda r2 = new Roda();
        r2.cor = "Vermelha";
        r2.aro = 22;

        Moto minhaMoto = new Moto("Azul", r1, r2);
        */

        //-----------------------------------------------
        //---> Encapsulamento <--- 
        //-----------------------------------------------
        /*
        Cripto cp = new Cripto();
        cp.setValor("aeiou");
        System.Console.WriteLine(cp.getValor());
        */

        //-----------------------------------------------
        //---> Herança <--- 
        //-----------------------------------------------
        /*
        Homem eu = new Homem();
        eu.Idade = 30;
        eu.Nome = "João da Silva";
        eu.TamanhoBarba = 0;

        Mulher mi = new Mulher();
        mi.TamanhoBusto = 80;
        mi.Nome = "Maria da Silva";
        mi.Idade = 21;
        */

        //-----------------------------------------------
        //---> Polimorfismo <---
        //-----------------------------------------------
        /*
        Mamifero m1 = new Leao();
        m1.Andar();

        Mamifero m2 = new Gorila();
        m2.Andar();
        */

        //-----------------------------------------------
        //---> Polimorfismo 2 <---
        //-----------------------------------------------
        /*
        Operacao op = new Soma();
        double n1 = 5, n2 = 4;
        new Calcular().MostrarResultado(op, n1, n2);


        Operacao opp = new Subtracao();
        //double n1 = 5, n2 = 5;
        new Calcular().MostrarResultado(opp, n1, n2);
        */

        //-----------------------------------------------
        //---> Sobreposição <---
        //-----------------------------------------------

        Poupanca p1 = new Poupanca();
        p1.Saque("99999-9", "1234-5", 100);

        Corrente c1 = new Corrente();
        c1.Saque("88888-8", "5432-1", 100);
    }
}

