namespace Neighborfood.DTOs
{
    public class ReseñaDTO
    {
        public int PK_ReseñaID { get; set; }
        public string? RES_Contenido { get; set; }
  
        public double RES_Calificacion { get; set; }
     
        public DateTime RES_FechaCreacion { get; set; }
      
        public long? FK_RestauranteID { get; set; }
    }
}
