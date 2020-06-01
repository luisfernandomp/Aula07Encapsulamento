using System;

namespace pooEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            MasterCard master = new MasterCard();
            card.aprovarCompra();
            card.titular = "Luis Fernando";
            card.numero = "12345";
            Console.WriteLine(card.titular);
            Console.WriteLine(card.numero);
            master.bandeira = "Maestro";
            Console.WriteLine(master.bandeira);
            master.parcelas = 3;
            master.ComprarComDescontoMasterCard(50f);
        }
    }
}
