using System.ComponentModel.DataAnnotations.Schema;

namespace Appiss1.Modelos
{
    public class PlanRecompensas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Puntos { get; set; }
        public string TipoPlan
        {
            get
            {
                if (Puntos >= 500)

                {
                    return "GOLD";
                }
                else
                {
                    return "SILVER";
                }
            }
        }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
