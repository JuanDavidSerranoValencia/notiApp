using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Submodulo : BaseEntity
{
    [Required]
    public string NombreSubmodulo { get; set; }
    [Required]
    public DateTime FechaCreacion { get; set; }
    [Required]
    public DateTime FechaModificacion { get; set; }


    public ICollection<MaestroVsSubmodulo> MaestrosVsSubmodulos{ get; set; }

}
