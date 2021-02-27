namespace Curso.Entities
{
    public abstract class Payer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payer (string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}