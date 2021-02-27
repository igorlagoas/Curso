using System;

namespace Curso.Entities
{
    public class Company : Payer
    {
        public int EmployeesNumber { get; set; }

        public Company (string name, double anualIncome, int employeeNumber) : base (name, anualIncome)
        {
            EmployeesNumber = employeeNumber;
        }

        public override double TaxesPaid()
        {
            if (EmployeesNumber > 10)
            {
                return AnualIncome * 0.14;
            }

            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}