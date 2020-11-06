namespace RH.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; }
        public string Descripcion { get; set; }
        public string Requisitos { get; set; }
        public string ExperienciaMinima { get; set; }
        public int CentroCostoId { get; set; }
    }
}
