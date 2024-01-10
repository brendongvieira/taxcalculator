namespace TaxCalculator.Entities
{
    class TaxCompany : Tax
    {
        public int Employees { get; set; }

        public TaxCompany(string name, double income, int employees) : base(name, income)
        {
            Employees = employees;
        }

        public override double TaxAmount()
        {
            if (Employees > 10)
            {
                return Income * 0.14;

            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}