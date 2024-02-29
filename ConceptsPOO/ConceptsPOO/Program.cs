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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);


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