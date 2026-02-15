using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DirectorioEmpleadosMawi.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        List<Empleado> Empleados { get; set; }
    }
}
