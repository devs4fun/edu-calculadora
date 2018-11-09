using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o primeiro algarismo");
            string Algarismo1 = Console.ReadLine();
            decimal Algarismo1emdecimal = Convert.ToDecimal(Algarismo1);

            Console.WriteLine("Digite o operador");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo algarimo");
            string Algarismo2 = Console.ReadLine();
            decimal Algarismo2emdecimal = Convert.ToDecimal(Algarismo2);

            decimal resultado = 0;

            decimal resto = 0;

            if(operador== "+")
            {
                resultado =
                    Algarismo1emdecimal +
                    Algarismo2emdecimal;
            }
            else if (operador == "-")
            {
                resultado =
                    Algarismo1emdecimal -
                    Algarismo2emdecimal;
            }
            else if (operador == "*")
            {
                resultado =
                    Algarismo1emdecimal *
                    Algarismo2emdecimal;
            }
            else if (operador == "/")
            {
                resultado =
                    Algarismo1emdecimal /
                    Algarismo2emdecimal;

                resto =
                    Algarismo1emdecimal %
                    Algarismo2emdecimal;
                Console.WriteLine("O resto da divisão é =" + resto);
            }

            Console.WriteLine("O resultado foi = " + resultado);
            if (resultado % 2 == 0)
                Console.WriteLine("par");
            else
                Console.WriteLine("impar");
            Console.ReadKey();
           
        }
    }
}
