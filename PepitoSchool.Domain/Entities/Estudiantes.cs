using System;

namespace PepitoSchool.Domain
{
    public class Estudiantes
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Carnet { get; set; }
        public decimal Phone { get; set; }
        public string Dirrecion { get; set; }
        public string Correo { get; set; }
        public int Matematica { get; set; }
        public int Contabilidad  { get; set; }
        public int Programaciion { get; set; }
        public int Estadisticas { get; set; }

    }
}
