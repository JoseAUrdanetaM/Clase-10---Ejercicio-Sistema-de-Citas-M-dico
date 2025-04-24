using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Modelos
{
    public class Paciente
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Paciente()
        {
            Id = _nextId++;
        }
    }
}
