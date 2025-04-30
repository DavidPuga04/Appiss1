using System.ComponentModel.DataAnnotations;

namespace Appiss1.Modelos
{
    public class Cliente
    {
        [Key] 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsVIP { get; set; }
        public string PugaD { get; set; }
    }
}
