using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region properties
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? BirthDate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsActive { get; set; }
        #endregion

        #region Methods
        public Employee()
        {

        }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"Información empleado \n\t " +
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de Cumpleaños: {BirthDate}\n\t" +
                $"Fecha contratación: {HiringDate}\n\t" +
                $"¿Empleado activo: {IsActive}\n\t";
        }


        #endregion
    }
}
