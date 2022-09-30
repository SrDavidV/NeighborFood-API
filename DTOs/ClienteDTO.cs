namespace Neighborfood.DTOs
{
    public class ClienteDTO
    {

        public long PK_Cedula { get; set; }
        public string CLI_Nombre { get; set; }
        public string CLI_Apellido { get; set; }
        public string CLI_Password { get; set; } 
        public DateTime CLI_FechaRegistro { get; set; } 
        public string CLI_Telefono { get; set; } 
        public string CLI_Ciudad { get; set; } 
        public string CLI_Correo { get; set; } 
        public string? CLI_Genero { get; set; }
        public int? CLI_Puntos { get; set; }
        public bool CLI_Estado { get; set; } = true;

    }
}
