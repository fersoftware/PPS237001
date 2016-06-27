using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS237001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;

            
            do
            {
                try
                {
                    Console.Write("Digite um valor: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor Inválido");
                    n = 0;
                }
                    

                if (n < 4)
                {
                    Console.WriteLine("Número Inválido, digite novamente");
                }

            } while (n < 4);
            

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        Console.Write("Favor preencha com um valor: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor Inválido");  
                    }                    
                }
            }


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matriz[i,j]);
                }

                Console.WriteLine();
            }


            do
            {
                try
                {
                    Console.Write("Digite um número que seja a posição da linha: ");
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor Inválido");
                    x = 0;
                }


                if (x < 0 )
                {
                    Console.WriteLine("Número Inválido, digite novamente");
                }

            } while (x < 0 || x >= n);
            

            Console.WriteLine("O total de pares foram {0}", ContaParesLinha(matriz,x));
            Console.ReadKey();
        }

        static int ContaParesLinha(int[,] matriz, int x)
        {
            int conta = 0;
            
            for (int j = 0; j < matriz.GetLength(1) ; j++)
            {
                if(matriz[x,j] %2 == 0)
                {
                    conta++;
                }
            }
            
            return conta;
        }
    }
}
