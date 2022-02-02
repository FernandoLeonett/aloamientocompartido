using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharedHostApplicacion.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        public Cliente ClienteSolicitante { get; set; }
      public House House { get; set; }
    }
}