using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1069Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                int cont = 0;
                char[] texto = Console.ReadLine().ToCharArray();

                for (int i = 0; i < texto.Length; i++)
                {
                    if ('<' == texto[i])
                    {
                        for (int l = i; l < texto.Length; l++)
                        {
                            if('>'== texto[l])
                            {
                                cont++;
                                texto[l] = '.';
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine(cont);
                
            }
            Console.ReadLine();
        }
    }
}
