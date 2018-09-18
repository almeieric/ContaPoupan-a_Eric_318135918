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

            ContaPoupanca poupador1 = new ContaPoupanca(2000);

            Console.WriteLine(poupador1.CalcularJurosMensal(2000, 4));
            Console.WriteLine("\n\n\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);


        }//fim do Program
    }
    class ContaPoupanca
    {


        private double saldoPoupanca;
        private double taxaDeJurosAnual;
        

        
          
        
        public ContaPoupanca()
        {
            this.saldoPoupanca = 0.0;
            this.taxaDeJurosAnual = 0.0;
            

        } 
        public ContaPoupanca(double saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
            
        }
        public double CalcularJurosMensal(double saldoPoupanca, double taxaDeJurosAnual)
        {
            return ((saldoPoupanca * taxaDeJurosAnual) /100 )/ 12;
        }
        static double AlterarTaxaJuros()
        {
            return 1;
        }










    }//fim do conta poupança
}
