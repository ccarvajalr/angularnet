using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAngular.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Maximo 50", MinimumLength = 2)]
        public string Marca { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Maximo 50", MinimumLength = 2)]
        public string Modelo { get; set; }
    }
}