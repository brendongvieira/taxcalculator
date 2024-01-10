namespace TaxCalculator.Entities
{
      class TaxIndividual : Tax
    {
        public double Expenditures { get; set; }

        public TaxIndividual(string name, double income, double expenditures) : base(name, income)
        {
            Expenditures = expenditures;
        }

        public override double TaxAmount()
        {
            if (Income < 20000.00)
            {
                return Income * 0.15 - Expenditures * 0.5;
                
            } else
            {
                return Income * 0.25 - Expenditures * 0.5;
             
            }
        }
    }
}
