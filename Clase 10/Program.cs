using Clase_10.Modelos;

namespace Clase_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Citas Médicas ===\n");

            SistemaCitasMedicas sistema = new SistemaCitasMedicas();
            CargarDatosIniciales(sistema); // Yo ya tengo cargado los datos de las listas que estan en Sistema Inventario


            // Menu de entrada
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Ver Pacientes");
                Console.WriteLine("2. Generar Cita");
                Console.WriteLine("3. Ver Citas");
                Console.WriteLine("4. Cancelar Cita");
                Console.WriteLine("0. Salir");

                Console.WriteLine("\n Seleccione una opcion: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());
                    // Entra aqui -> 
                    switch (opcion)
                    {
                        case 1:
                            GestionPacientes(sistema);
                            break;
                        case 0:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
                catch (Exception ex) // throw an error
                {
                    Console.WriteLine(ex.Message); // IndexOutOfRangeException // En internet
                }
            }
        }

        static void CargarDatosIniciales(SistemaCitasMedicas sistema)
        {
            // Agregar los pacientes
            var paciente1 = new Paciente
            {
                Nombre = "Andre Antonio",
                Edad = 20,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now
            };

            var paciente2 = new Paciente
            {
                Nombre = "Juan Perez",
                Edad = 45,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now
            };

            sistema.AgregarPaciente(paciente1);
            sistema.AgregarPaciente(paciente2);

        }

        static void GestionPacientes(SistemaCitasMedicas sistema)
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Pacientes: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un Paciente");
                Console.WriteLine("2. Ver lista de pacientes");
                Console.WriteLine("3. Ver paciente por Id");
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarPaciente(sistema);
                        break;
                    case "2":
                        VerTodosLosPacientes(sistema);
                        break;
                    case "3":
                        VerPaciente(sistema);
                        break;
                    case "0":
                        regresar = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }
        static void AgregarPaciente(SistemaCitasMedicas sistema)
        {
            Console.WriteLine("\nAgregar un nuevo Paciente: ");

            Console.WriteLine("Nombre del Paciente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Mencione su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            var paciente = new Paciente
            {
                Nombre = nombre,
                Edad = edad,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now

            };

            sistema.AgregarPaciente(paciente);
            Console.WriteLine($"\n Paciente agregado con el ID: {paciente.Id}");
        }
        static void VerTodosLosPacientes(SistemaCitasMedicas sistema)
        {
            var pacientes = sistema.ObtenerPacientes();

            // Validar si no hay empleados
            if (pacientes.Count == 0)
            {
                Console.WriteLine("No hay ningun Paciente");
                return;
            }

            Console.WriteLine("Lista de Pacientes");
            Console.WriteLine("ID\tNombres\t\tEdad");
            Console.WriteLine("-------------------------------------");
            foreach (var paciente in pacientes)
            {
                Console.WriteLine($"{paciente.Id}\t{paciente.Nombre}\t{paciente.Edad}");
            }
        }
        static void VerPaciente(SistemaCitasMedicas sistema)
        {
            Console.WriteLine("\nMostrar Paciente por Id: ");
            Console.WriteLine("Ingresa el Id del Paciente: ");

            int id = int.Parse(Console.ReadLine());

            // Validar si el id existe

            var paciente = sistema.ObtenerPacientesPorId(id);

            Console.WriteLine("ID\tNombres\tEdad");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"{paciente.Id}\t{paciente.Nombre}\t{paciente.Edad}");
        }
    }
}
    
