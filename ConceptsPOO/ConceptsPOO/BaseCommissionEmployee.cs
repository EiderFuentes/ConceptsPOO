namespace ConceptsPOO
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            //Interpoblacion de la clase empleado mas lo que modifico 
            //una doble interpoblacion y me lo ocupe en 18 caracteres
            return $"{base.ToString()}" +
                $"\n\tBase................: {$"{Base:C2}",18}";
        }
    }
}
