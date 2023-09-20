using EmployeeOOP.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int day, month, year, id;
            string firstName, lastName;
            decimal salary, hourValue;
            bool isActive;
            float hours;



            Console.WriteLine("OPP APLICACIÓN");
            Console.WriteLine("---------------");


            Console.Write("Ingresar el dia: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el mes: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            
            Date dateObject = new Date(day, month, year);
            Console.WriteLine();
            Console.WriteLine(dateObject.ToString());

            Console.WriteLine();

            Console.WriteLine("Salario");

            Console.Write("Ingrese su identificación: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese nombre completo: ");
            firstName = Console.ReadLine();

            Console.Write("Ingrese apellidos completos: ");
            lastName = Console.ReadLine();

            Console.Write("Ingrese salario devengado: ");
            salary = decimal.Parse(Console.ReadLine());

            
            SalaryEmployee salaryEmployee = new SalaryEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = true,
                Salary = salary,
            };

            Console.WriteLine(salaryEmployee);

            Console.WriteLine("Ventas");

            Employee commissionEmployee = new CommissionEmployee()
            {
                Id = 1000393659,
                FirstName = "Valentina",
                LastName = "Torres Zuluaga",
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = true,
                CommisionPercentaje = 5,
                Sales = 2000000,
            };

            Console.WriteLine(commissionEmployee);

            Console.WriteLine("Valor x hora");

            Console.Write("Ingrese su identificación: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su nombre completo: ");
            firstName = Console.ReadLine();

            Console.Write("Ingrese apellidos completos: ");
            lastName = Console.ReadLine();

            Console.Write(" ¿Eres empleado activo (true/false)?: ");
            isActive = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingresar horas trabajadas: ");
            hours = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresar valor hora: ");
            hourValue = Convert.ToDecimal(Console.ReadLine());

            Employee hourtyEmployee = new HourtyEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = isActive,
                Hours = hours,
                HourValue = hourValue,

            };

            Console.WriteLine(hourtyEmployee);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }
    }
}