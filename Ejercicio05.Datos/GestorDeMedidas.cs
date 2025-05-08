using Ejercicio05.Entidades;

namespace Ejercicio05.Datos
{
    public class GestorDeMedidas
    {
        private List<Medida> medidas=null!;

        public GestorDeMedidas()
        {
            medidas = new List<Medida>();
        }
        public List<Medida> GetLista()
        {
            return medidas;
        }
        public bool Agregar(Medida medida)
        {
            if (Existe(medida)) return false;
            medidas.Add(medida);
            return true;
        }
        public bool Existe(Medida medida)
        {
            return medidas.Contains(medida);
        }
        public int GetCantidad()
        {
            return medidas.Count;
        }
        public static implicit operator int(GestorDeMedidas gestor)
        {
            return gestor.medidas.Count;
        }

        public static implicit operator double(GestorDeMedidas gestor)
        {
            return gestor.medidas.Sum(m => m.Valor);
        }
        public static bool operator+(GestorDeMedidas gestor, Medida medida)
        {
            if(gestor==medida) return false;
            gestor.medidas.Add(medida);
            return true;
        }
        public static bool operator ==(GestorDeMedidas gestor,Medida medida)
        {
            return gestor.medidas.Contains(medida);
        }
        public static bool operator !=(GestorDeMedidas gestor, Medida medida)
        {
            return !(gestor == medida);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }
            if (obj.GetType() != typeof(GestorDeMedidas)) return false;
            GestorDeMedidas otroGestor = (GestorDeMedidas)obj;
            if (this.medidas.Count!=otroGestor.medidas.Count)
            {
                return false;
            }
            for (int i = 0; i < medidas.Count; i++)
            {
                if (!this.medidas[i].Equals(otroGestor.medidas[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            var hash = 17;
            foreach (var medida in medidas)
            {
                hash = hash * 31 + medida.GetHashCode();
            }
            return hash;
        }
    }
}
