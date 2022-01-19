namespace TaxValue.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberofemployees, string name, double anualincome)
            : base(name, anualincome)
        {
            NumberOfEmployees = numberofemployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return 0.16 * AnualIncome;
            }

            else
            {
                return 0.14 * AnualIncome;
            }
        }
    }
}
