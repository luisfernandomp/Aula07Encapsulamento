using System;
namespace pooEncapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        private string token = "asd13212aASASDDFEWEZ12asd2112312as912389djaskf";
        protected string cvv { get; set; }
        
        public void aprovarCompra(){
            
            Console.WriteLine("Compra Aprovada!");
        }
        private bool validarToken(){
            if(token != null){
                return true;  
            }
            return false;
        }
        protected bool validarCompra(){
            return true;
        }

    }
}