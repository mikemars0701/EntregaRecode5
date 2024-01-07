using System.ComponentModel.DataAnnotations.Schema;

namespace SpacebookAPI.Model
{
    [Table("Viagem")]
    public class Viagem
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("viagem_destino")]
        public string Destino { get; set; } = string.Empty;

        [Column("viagem_url")]
        public string ViagemURL { get; set; } = string.Empty;

        [Column("viagem_preco")]
        public decimal Preco { get; set; }
    }
}
