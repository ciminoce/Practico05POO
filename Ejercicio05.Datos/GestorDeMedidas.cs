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
    }
}
