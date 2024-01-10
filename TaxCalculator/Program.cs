using System;
using System.Globalization;
using TaxCalculator.Entities;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tax> list = new List<Tax>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    list.Add(new TaxIndividual(name, income, expenditures));
                    
                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new TaxCompany(name, income, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totaltaxes = 0;

            foreach (Tax tax in list)
            {
                Console.WriteLine($"{tax.Name}: $ {tax.TaxAmount().ToString("F2", CultureInfo.InvariantCulture)}");
                totaltaxes += tax.TaxAmount();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {totaltaxes.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}