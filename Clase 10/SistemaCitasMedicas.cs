using Clase_10.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class SistemaCitasMedicas
    {

        private List<Paciente> _pacientes = new List<Paciente>();
        private List<Doctor> _doctores = new List<Doctor>();
        private List<Consultorio> _consultorios = new List<Consultorio>();

        // Metodo para agregar un tipo empleado
        public void AgregarPaciente(Paciente paciente)
        {
            _pacientes.Add(paciente);
        }

        // Metodo para listar todos los tipos de empleados
        public List<Paciente> ObtenerPacientes()
        {
            return _pacientes.ToList();
        }

        // Metodo para obtener un solo empleado y quiero que sea por Id
        public Paciente ObtenerPacientesPorId(int id)
        {
            return _pacientes.FirstOrDefault(t => t.Id == id);
        }

    }
}
