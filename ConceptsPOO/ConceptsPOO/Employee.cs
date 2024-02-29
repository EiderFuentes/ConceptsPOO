namespace ConceptsPOO
{
    //Clase Abstracta
    //Clase empleado implementa la interfase Ipay
    public abstract class Employee : Ipay
    {
        // Cedula
        public int Id { get; set; }
        //Nombres
        public string FirstName { get; set; }
        //Apellidos
        public string LastName { get; set; }
        //Fecha Nacimiento
        // la clase Date es una composicion
        public Date BirthDate { get; set; }
        //Fecha Contratacion
        public Date HiringDate { get; set; }
        //Activo
        public bool IsActive { get; set; }

        //Metodo Abstracto
        public abstract decimal GetValueToPay();

        //Sobrescribir el metodod toString()
        public override string ToString()
        {
            //interPoblacion de string
            return $"{Id} - {FirstName} {LastName}, Birth: {BirthDate}, Hiring: {HiringDate}, Is Active: {IsActive} ";
        }

    }
}
