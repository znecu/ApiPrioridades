using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrioridades.Core.Entities
{
    public class Prioridades
    {
        [Key]
        public int PrioridadesId { get; set; }

        [Required(ErrorMessage ="La Descripcion es requerida.")]
        public string Descripcion { get; set; } = null!;
    }
}
