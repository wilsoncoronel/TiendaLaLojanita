using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface ISistemaService
    {
        Task<List<PersonaDTO>> ListaPersonas();
        Task<PersonaCompletoDTO> BuscarPersonaCompleto(int IdPersona);
        Task<List<RolDTO>> ListaRoles();
    }
}
