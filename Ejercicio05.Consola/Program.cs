using Ejercicio05.Datos;
using Ejercicio05.Entidades;
using Ejercicio05.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio05.Consola
{
    internal class Program
    {
        static GestorDeMedidas gestor = new GestorDeMedidas();

        static void Main(string[] args)
        {
            bool seguir = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Manejo de Medidas");
                Console.WriteLine("1 - Listar Medidas");
                Console.WriteLine("2 - Agregar Medidas");
                Console.WriteLine("x - Salir");
                var opcion = ExtensionesConsola.PedirString("Ingrese la selección:");
                switch (opcion)
                {
                    case "1":
                        ListarMedidas();
                        break;
                    case "2":
                        AgregarMedidas();
                        break;
                    case "x":
                        seguir = false;
                        break;
                    default:
                        Console.WriteLine("Selección no válida");
                        break;
                }

            } while (seguir);
        }

        private static void ListarMedidas()
        {
            Console.Clear();
            Console.WriteLine("Listado de Medidas");
            foreach (var medida in gestor.GetLista())
            {
                Console.WriteLine(medida);
            }
            Console.ReadKey();
        }

        private static void AgregarMedidas()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Ingreso de medidas");
                var valor = ExtensionesConsola.PedirDoble("Ingrese el valor de la medida (0 para salir):");
                if (valor == 0) return;
                Medida medida = new Medida(valor);

                var context = new ValidationContext(medida);
                var errores = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(medida, context, errores, true);
                if (isValid)
                {
                    var respuesta = ExtensionesConsola.ConfirmarDatos("¿Confirma que agrega esta medida? (s/n):");
                    if (respuesta)
                    {
                        if (gestor.Agregar(medida))
                        {
                            Console.WriteLine($"{medida} agregada satisfactoriamente!!!");
                        }
                        else
                        {
                            Console.WriteLine($"{medida} ya existe en el archivo");
                        }
                    }

                }
                else
                {
                    Console.WriteLine(errores.First().ErrorMessage);
                }
                Console.ReadKey();

            } while (true);
        }
    }
}
