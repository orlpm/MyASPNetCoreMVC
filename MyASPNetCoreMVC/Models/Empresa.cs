using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyASPNetCoreMVC.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre  { get; set; }

        [MaxLength(80)]
        public string RazonSocial { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        [MaxLength(12)]
        public string RFC { get; set; }

        public List<Trabajador> Trabajadores { get; set; }
    }
}
