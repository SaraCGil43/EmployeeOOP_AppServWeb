using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class HourtyEmployee : Employee
    {
        #region Properties

        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourtyEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            
            return HourValue * (decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Horas Trabajadas: {Hours:F2}\n" +
                   $"Valor por Hora: {HourValue:C2}\n" +
                   $"Total valor: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
