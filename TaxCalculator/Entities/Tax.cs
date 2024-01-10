using System;

namespace TaxCalculator.Entities
{
    abstract class Tax
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Tax(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TaxAmount();
    }
}
