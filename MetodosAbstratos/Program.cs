using System;
using System.Globalization;
using System.Collections.Generic;
using MetodosAbstratos.Entities;

namespace MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company(i/c) : ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmployee));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (Pessoa pess in list)
            {
                double tax = pess.Tax();
                Console.WriteLine(pess.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
