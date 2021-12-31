using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyASPNetCoreMVC.Models
{
    public class Trabajador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }

        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
    }
}
