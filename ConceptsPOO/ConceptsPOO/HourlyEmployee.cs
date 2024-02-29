namespace ConceptsPOO
{
    // Herreda de la clase Employee
    public class HourlyEmployee : Employee
    {

        public float Hours { get; set; }


        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            //Interpoblacion de la clase empleado mas lo que modifico 
            //una doble interpoblacion y me lo ocupe en 18 caracteres
            return $"{base.ToString()}" +
                $"\n\tHours...............: {$"{Hours:N2}",18}" +
                 $"\n\tHourValue..........: {$"{HourValue:C2}",18}" +
                $"\n\tValue to pay........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
