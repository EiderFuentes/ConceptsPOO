using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        //Metodo Abstracto
        public override decimal GetValueToPay()
        {
            //Convierto un float a decimal hago un casig
            return Sales * (decimal)CommissionPercentaje;  
        }

        public override string ToString()
        {
            //Interpoblacion de la clase empleado mas lo que modifico 
            //una doble interpoblacion y me lo ocupe en 18 caracteres
            return $"{base.ToString()}" +
                $"\n\tCommission Percentaje: {$"{CommissionPercentaje:P2}", 18}" +
                 $"\n\tSales..............: {$"{Sales:C2}", 18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
