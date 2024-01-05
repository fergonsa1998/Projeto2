using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é permitido divisao por zero!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
        }
    }
}


