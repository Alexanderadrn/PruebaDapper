using PruebaDapper.DTO;

namespace PruebaDapper.Service
{
    public interface IPersonaService
    {
        public Task<List<PersonaDTO>> ObtenerPersona(string cedula);
    }
}
