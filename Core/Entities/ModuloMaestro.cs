using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class ModuloMaestro : BaseEntity
{
    [Required]
    public string NombreModulo { get; set; }
    [Required]
    public DateTime FechaCreacion { get; set; }
    [Required]
    public DateTime FechaModificacion { get; set; }
}
