using System;
using System.Linq;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantDeValores;
            
            Console.WriteLine("Digite a quantidade de valores que deseja ler: ");
            quantDeValores = Convert.ToInt32(Console.ReadLine());
            int[] valores = new int[quantDeValores];
            

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Digite o valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }
            int contador = 0;
       

            for(int i = 0;i < valores.Length; i++)
            {
                contador = 0;
                for (int j = 0; j < valores.Length; j++)
                {
                    if (valores[i] == valores[j])
                    {
                        contador++;

                    }
                   
                }
              
                Console.WriteLine("{0} aparece {1} vezes", valores[i], contador);
            }
            Console.ReadLine();
        }
    }
}
