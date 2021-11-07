using System;

namespace AppProvaLogicProg_Exerc_01
{
    class Program
    {
        public static float Cacluar(int CodigoPeca, int NumeroPeca, float ValorPeca) 
        {
            float ValorTotal;  
            ValorTotal = (NumeroPeca * ValorPeca);
            return ValorTotal;  
        }

        public static void ZerarVariaveis(int Codigo, int NumeroPec, float ValorUnitario)
        {
            Codigo = 0;
            NumeroPec = 0;
            ValorUnitario = 0;
        }

        static void Main(string[] args)
        {
            int Codigo;
            int NumeroPec;
            float ValorUnitario;

            float VlTotal1;
            float VlTotal2;
            float Total;

            //Entrada com o primeiro valor
            Console.WriteLine("Ditite o codigo da peça: ");
            Codigo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ditite o número de peças: ");
            NumeroPec = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitario de cada peça: ");
            ValorUnitario = float.Parse(Console.ReadLine());

            VlTotal1 = Cacluar(Codigo, NumeroPec, ValorUnitario);
            
            ZerarVariaveis(Codigo, NumeroPec, ValorUnitario);

            //Entrada com o segundo valor.
            Console.WriteLine("Ditite o codigo da peça: ");
            Codigo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ditite o número de peças: ");
            NumeroPec = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitario de cada peça: ");
            ValorUnitario = float.Parse(Console.ReadLine());
            VlTotal2 = Cacluar(Codigo, NumeroPec, ValorUnitario);
            Total = VlTotal1 + VlTotal2;

            Console.WriteLine($"O valor total a ser pago é: {Total}");
            Console.ReadLine();

        }
    }
}
