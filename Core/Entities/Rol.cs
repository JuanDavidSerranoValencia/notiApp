using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Rol : BaseEntity
{
    [Required]
    public string NombreRol { get; set; }
    [Required]
    public DateTime FechaCreacion { get; set; }
    [Required]
    public DateTime FechaModificacion { get; set; }

    public ICollection<RolVsMaestro> RolsVsMaestros  { get; set; }

    public ICollection<GenericVsSubmodulo> GenericsVsSubmodulos  { get; set; }

}
