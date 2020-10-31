using System;

namespace RH.WindowsApp.Modelos
{
    public class Empleado
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int TipoDocIdentificacion { get; set; }
        public Int64 NumDocIdentificacion { get; set; }
        public string Direccion { get; set; }
        public int CiudadId { get; set; }
        public int GeneroId { get; set; }
        public Int64 Celular { get; set; }
        public int EstadoCivilId { get; set; }
        public int CargoId { get; set; }
        public string Jefe { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CentroCostoId { get; set; }
        public Int64 Salario { get; set; }
    }
}
