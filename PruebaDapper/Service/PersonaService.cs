using Dapper;
using Microsoft.Data.SqlClient;
using PruebaDapper.DTO;
using PruebaDapper.Service;

public class PersonaService : IPersonaService
{
    private readonly string _connectionString;

    public PersonaService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<List<PersonaDTO>> ObtenerPersona()
    {
        using var connection = new SqlConnection(_connectionString);
        string query = @"SELECT TOP 1000 *
                         FROM HCK_PERSONAS";

        var personas = await connection.QueryAsync<PersonaDTO>(query);
        return personas.ToList();
    }
}