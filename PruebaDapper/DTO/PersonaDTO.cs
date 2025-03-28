namespace PruebaDapper.DTO
{
    public class PersonaDTO
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ciudadania { get; set; }
        public DateTime? Fecha_Nacimiento { get; set; }
        public string Estado_Civil { get; set; }
        public string Profesion { get; set; }
        public string Nivel_Estudios { get; set; }
        public int? Es_Cliente { get; set; }
        public string Tipo_Persona { get; set; }
    }
}
