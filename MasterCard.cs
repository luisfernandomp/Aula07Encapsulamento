using System;

namespace pooEncapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; }
        
        public void ComprarComDescontoMasterCard(float desconto){
            cvv ="456";
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");

        }
    }
}