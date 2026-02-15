using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DirectorioEmpleadosMawi.Models
{
    public class Sede
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("localidad")]
        public string Localidad { get; set; }
      

        List<Empleado> Empleados { get; set; }
    }
}
