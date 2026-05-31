using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entidades
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int LibroId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime FechaPrestamo { get; set; }
    }
}
