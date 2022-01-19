﻿namespace TaxValue.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthexpenditures, string name, double anualincome)
            : base(name, anualincome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
               
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
                
        }
    }
}
