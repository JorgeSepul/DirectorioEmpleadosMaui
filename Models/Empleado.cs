using System;
using System.Collections.Generic;
using System.Text;

namespace DirectorioEmpleadosMawi.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Departamento_id { get; set; }
        public int Sede_id { get; set; }
        public string? Image_url { get; set; }


        Departamento departamento { get; set; }
        Sede sede { get; set; }
    }
}
