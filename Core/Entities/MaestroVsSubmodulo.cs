using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class MaestroVsSubmodulo : BaseEntity
{

    [Required]
    public DateTime FechaCreacion { get; set; }
    [Required]
    public DateTime FechaModificacion { get; set; }


    public ICollection<GenericVsSubmodulo> GenericsVsSubmodulos { get; set; }
    public int IdModuloMaestroFk { get; set; }
    public ModuloMaestro ModuloMaestro{ get; set; }


    public int IdSubmoduloFk { get; set; }
    public Submodulo Submodulo { get; set; }

}
