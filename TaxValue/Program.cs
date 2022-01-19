using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using TaxValue.Entities;

namespace TaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the numer of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CI);

                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Individual(health, name, anualincome));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine(), CI);
                    list.Add(new Company(employees, name, anualincome));
                }

            }


            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CI));
            }

            Console.WriteLine();
            double total = list.Sum(c => c.Tax());
            Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2", CI));






        }
    }
}
