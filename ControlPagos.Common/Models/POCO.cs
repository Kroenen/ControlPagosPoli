using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPagos.Common.Models
{

    [Table("Tema")]
    public class Temas
    {
        [Key]
        public int IdTema { get; set; } = 0;
        
        [Required(ErrorMessage ="El titulo no puede estar vacio")]
        [MaxLength(50)]
        public string Titulo { get; set; } = "";
        public Nullable<DateTime> FechaCreado {
            get;
            set; } = DateTime.Now;
    }
}
