using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SharedHostApplicacion.Models
{
    public class House
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }
        public Direccion Direccion { get; set; }

        public int CantidadOcupantes { get; set; }
      

        public bool Parejas { get; set; }

        public bool Mascota { get; set; }

        public bool Children { get; set; }

        [Column(TypeName = "image")]
        public List<byte[]> Imagenes { get; set; }
    }
}