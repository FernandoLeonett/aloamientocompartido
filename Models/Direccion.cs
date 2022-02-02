using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharedHostApplicacion.Models
{
    public class Direccion
    {
        public int Id { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Barrio { get; set; }
        public string Calle { get; set; }
        public string NroPuerta { get; set; }
    }
}