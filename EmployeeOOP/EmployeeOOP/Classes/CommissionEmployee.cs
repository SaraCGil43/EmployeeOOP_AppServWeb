using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Propieties

        public decimal CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public CommissionEmployee()
        {

        }
        public override decimal GetValueToPay()
        {
            return Sales * (CommisionPercentaje / 100);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Porcentaje de Comisión: {CommisionPercentaje}%\n" +
                   $"Ventas: {Sales:C2}\n" +
                   $"Total: {GetValueToPay():C2}\n\t";
        }
        #endregion

    }
}
