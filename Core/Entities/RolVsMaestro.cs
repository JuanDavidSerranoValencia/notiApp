using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class RolVsMaestro : BaseEntity
{

    [Required]
    public DateTime FechaCreacion { get; set; }
    [Required]
    public DateTime FechaModificacion { get; set; }


    public int IdRolFk { get; set; }
    public Rol Rol { get; set; }


    public int IdModuloMaestroFk { get; set; }
    public ModuloMaestro ModuloMaestro { get; set; }

}
