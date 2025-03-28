using Dapper;
using Microsoft.Data.SqlClient;
using PruebaDapper.DTO;
using PruebaDapper.Service;

public class PersonaService : IPersonaService
{
    private readonly string _connectionString;

    public PersonaService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("cadenaSQL");
    }

    public async Task<List<PersonaDTO>> ObtenerPersona(string cedula)
    {
        using var connection = new SqlConnection(_connectionString);
        string query = @"SELECT *
                         FROM HCK_PERSONAS WHERE CEDULA =@cedula";

        var personas = await connection.QueryAsync<PersonaDTO>(query, new { cedula });
        return personas.ToList();
    }
}
