using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace UniversityAPIBackend.Models.DataModels
{
    public class Curso
    {
        public string Nombre { get; set; } = String.Empty;
        [Required, MaxLength(280)]
        public string DescripcionCorta { get; set; } = String.Empty;
        public string DescripcionLarga { get; set;} = String.Empty;
        public string PublicoObjetivo { get; set; } = String.Empty;
        public string Objetivo { get;set; } = String.Empty;
        public string Requisitos { get; set; } = String.Empty;

        public enum Nivel
        {
            Basico,
            Intermedio,
            Avanzado
        }
    }
}
