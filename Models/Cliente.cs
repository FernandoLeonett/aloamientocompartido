using System;


namespace SharedHostApplicacion.Models
{
    public class Cliente
    {
        // comentaario de prueba git
        public int Id { get; set; }

        public Usuario Usuario { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public string Descripcion { get; set; }
        public string Ocupacion { get; set; }


    }
}