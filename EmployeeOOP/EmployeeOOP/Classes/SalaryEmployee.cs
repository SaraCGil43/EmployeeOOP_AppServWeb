using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {
        #region Propieties

        public decimal Salary { get; set; }

        #endregion


        #region Methods

        public SalaryEmployee()
        {

        }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Devengado: {Salary:C2}\n\t";
        }
        #endregion

    }
}
