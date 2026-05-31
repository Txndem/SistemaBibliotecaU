using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBiblioteca.Entidades;
using System.Collections.Generic;

namespace SistemaBiblioteca.Controlador
{
    
    public static class DataStore
    {
        public static List<Libro> Libros = new List<Libro>();
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Prestamo> Prestamos = new List<Prestamo>();
    }
}
