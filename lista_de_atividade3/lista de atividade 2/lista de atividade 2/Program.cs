using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal Poupador1 = 3000;
            Console.WriteLine("Saldo do poupador 1 é: " + Poupador1);

            decimal Juros = 0;



            ContaPoupanca poupador1 = new ContaPoupanca();

            if (Poupador1 == 3000)
            {
                Juros = 5;
            }
            
           
            decimal contaP1 = poupador1.CalcularJurosMensal(Poupador1, Juros) + Poupador1;
                        
            Console.WriteLine("seu saldo é = " + contaP1);

            decimal Poupador2 = 2000;
            Console.WriteLine("Saldo do poupador 2 é: " + Poupador2);

           
           
            ContaPoupanca poupador2 = new ContaPoupanca();

            if (Poupador2 == 2000)
            {
                Juros = 4;
            }
            
            decimal contaP2 = poupador1.CalcularJurosMensal(Poupador2, Juros) + Poupador2;
            

            Console.WriteLine("seu saldo é = " + contaP2);

            Console.WriteLine("\n\n\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);


        }//fim do Program
    }
    class ContaPoupanca
    {


        private decimal saldoPoupanca;
        
        

        
          
        
        public ContaPoupanca()
        {
            this.saldoPoupanca = 0;
           
            

        } 
        public ContaPoupanca(decimal saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
            
        }
        public decimal CalcularJurosMensal(decimal saldoPoupanca, decimal taxaDeJurosAnual)
        {
            return ((saldoPoupanca * taxaDeJurosAnual) /100 )/ 12;
        }
        static decimal AlterarTaxaJuros()
        {
            return 1;
        }









    }//fim do conta poupança
}
