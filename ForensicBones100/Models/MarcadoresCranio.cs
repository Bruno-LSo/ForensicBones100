using ForensicBones100.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones100.Models
{
    [Table("MarcadoresCranio")]
    public class MarcadoresCranio
    {
        [Key]
        public int MarcadoresCranioId { get; set; }

        [Required]
        public int InventarioCranioId { get; set; }

        public char CristaNucal { get; set; }
        public char ProcessoMastoide { get; set; }
        public char EminenciaMentoniana { get; set; }
        public char SupraOrbital { get; set; }
        public char AreaGlabela { get; set; }
        public char CalculoEstimativaSexo { get; set; }

        [StringLength(45)]
        public string Observacoes { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioId")]
        public virtual Relatorio Relatorio { get; set; }

        // Relação com a entidade InventarioCranio
        [ForeignKey("InventarioCranioId")]
        public virtual InventarioCranio InventarioCranio { get; set; }
    }
}