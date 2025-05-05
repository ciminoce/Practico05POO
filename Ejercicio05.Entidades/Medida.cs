using System.ComponentModel.DataAnnotations;

namespace Ejercicio05.Entidades
{
    public class Medida:IValidatableObject
    {
        private double valor;

        public Medida() : this(1)
        {

        }
        public Medida(double valor)
        {
            Valor = valor;
        }
        //Con un solo constructor
        //public Medida(double valor=1)
        //{
        //    Valor=valor;
        //}

        public double Valor { get => valor; set => valor = value; }
        public override string ToString()
        {
            return $"{Valor} mts.";
        }
        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(Medida)) return false;
            Medida otraMedida = (Medida)obj;
            return otraMedida.Valor == Valor;
        }
        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }
        public static Medida operator +(Medida m1, Medida m2)
        {
            return new Medida(m1.Valor + m2.Valor);
        }
        public static Medida operator -(Medida m1, Medida m2)
        {
            return new Medida(m1.Valor - m2.Valor);
        }
        public static bool operator ==(Medida m1, Medida m2)
        {
            if (m1 is null || m2 is null) return false;
            if (ReferenceEquals(m1, m2)) return true;
            return m1.Equals(m2);
        }
        public static bool operator !=(Medida m1, Medida m2)
        {
            return !(m1 == m2);
        }

        public double ConvertirMetrosCentimetros()
        {
            return Valor * 100;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (valor < 0)
            {
                yield return new ValidationResult("Valor de la medida no válido");
            }
        }

        public static implicit operator double(Medida m1)
        {
            return m1.Valor;
        }
    }
}
