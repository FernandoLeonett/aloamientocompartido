﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// comentario
namespace SharedHostApplicacion.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}