using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Usuario
{
    public class UpdateUsuarioDTO
    {
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCargo { get; set; }
    }
}
