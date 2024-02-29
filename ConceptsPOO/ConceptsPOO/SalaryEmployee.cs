namespace ConceptsPOO
{

    // Herreda la clase Empleado "Employye" es con los dos puentos " : "
    public class SalaryEmployee : Employee
    {

        //Propiedad
        public decimal Salary { get; set; }

        //Metodo que le voy a pagar el Empleado
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            //Interpoblacion de la clase empleado mas      una doble interpoblacion y me lo ocupe en 18 caracteres
            return $"{base.ToString()}\n\tValue to pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
