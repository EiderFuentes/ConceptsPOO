using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("==============");
//Clase Astracta o Interfac     dispara el constructor
Employee employee1 = new SalaryEmployee()
{
	Id = 1010,
	FirstName = "Eider",
	LastName = "Rivera",
	BirthDate = new Date(1989, 10, 08),
	HiringDate = new Date(2022, 1, 15),
	IsActive = true,
	Salary = 2815453.45M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Leidy",
    LastName = "Moreno",
    BirthDate = new Date(1991, 06, 28),
    HiringDate = new Date(2022, 1, 30),
    IsActive = true,
	Sales = 320000000M,
	CommissionPercentaje = 0.03F
   
};
//Console.WriteLine(employee2);


Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Natalia",
    LastName = "Fuentes",
    BirthDate = new Date(1990, 08, 30),
    HiringDate = new Date(2023, 1, 30),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F

};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Judith",
    LastName = "Rivera",
    BirthDate = new Date(1950, 09, 15),
    HiringDate = new Date(2008, 1, 30),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F

};
//Console.WriteLine(employee4);

// Creo una interfac todas las interfac empieza por la letra I
ICollection<Employee> employees = new List<Employee>()
{ 
  // tenemos una la colleccion de empeado
   employee1, employee2, employee3, employee4
};

//Inicializo el total de la nomina
decimal payroll = 0;

//totalizamos la nomina recorriendo la lista con el foreach
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);//Muesta el empleado
    payroll += employee.GetValueToPay(); //Suma todo los salario de los empleados
}

Console.WriteLine("                               ===================");
Console.WriteLine($"TOTAL                         {$"{payroll:C2}", 18}");


//Invocamos la clase factura
Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premun",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);



//Date date1 = new Date(2022, 2, 11);
//Console.WriteLine(date1);

// atajos 
// Ctrl + K + S saca el try y catch
//Ejemplo Clase Date 
//try
//{
//	Console.WriteLine(new Date(2024, 2, 29));
//	Console.WriteLine(new Date(1974, 9, 23));
//	Console.WriteLine(new Date(1985, 11, 30));
//}
//catch (Exception error)
//{

//	Console.WriteLine(error.Message);
//}