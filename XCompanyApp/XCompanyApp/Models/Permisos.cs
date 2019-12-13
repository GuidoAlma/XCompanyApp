using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace XCompanyApp.Models
{
    public class Permisos
    {       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string NombreEmpleado { get; set; }

        [Required]
        [MaxLength(500)]
        public string ApellidosEmpleado { get; set; }

        [Required]
        public DateTime FechaPermiso { get; set; }

        [Required]
        [ForeignKey("TipoPermiso")]
        public int TipoPermisoId { get; set; }
        
        public virtual TipoPermiso TipoPermiso { get; set; }
    }
}