using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ForensicBones100.Models
{
    [Table("InventarioCranio")]
    public class InventarioCranio
    {
        [Key]
        public int InventarioCranioId { get; set; }

        [Required]
        [ForeignKey("InventarioEsqueleto")]
        public int InventarioEsqueletoId { get; set; }

        public int Frontal { get; set; }
        [StringLength(45)]
        public string FrontalDesc { get; set; }

        public int Ocipital { get; set; }
        [StringLength(45)]
        public string OcipitalDesc { get; set; }

        public int Esfenoide { get; set; }
        [StringLength(45)]
        public string EsfenoideDesc { get; set; }

        public int Maxilar { get; set; }
        [StringLength(45)]
        public string MaxilarDesc { get; set; }

        public int Vomer { get; set; }
        [StringLength(45)]
        public string VomerDesc { get; set; }

        public int ParietalEsquerdo { get; set; }
        [StringLength(45)]
        public string ParietalEsquerdoDesc { get; set; }

        public int TemporalEsquerdo { get; set; }
        [StringLength(45)]
        public string TemporalEsquerdoDesc { get; set; }

        public int ConchaNasalInferiorEsquerda { get; set; }
        [StringLength(45)]
        public string ConchaNasalInferiorEsquerdaDesc { get; set; }

        public int Etmoide { get; set; }
        [StringLength(45)]
        public string EtmoideDesc { get; set; }

        public int LacrimalEsquerdo { get; set; }
        [StringLength(45)]
        public string LacrimalEsquerdoDesc { get; set; }

        public int NasalEsquerdo { get; set; }
        [StringLength(45)]
        public string NasalEsquerdoDesc { get; set; }

        public int ZigomaticoEsquerdo { get; set; }
        [StringLength(45)]
        public string ZigomaticoEsquerdoDesc { get; set; }

        public int ParietalDireito { get; set; }
        [StringLength(45)]
        public string ParietalDireitoDesc { get; set; }

        public int TemporalDireito { get; set; }
        [StringLength(45)]
        public string TemporalDireitoDesc { get; set; }

        public int ConchaNasalInferiorDireita { get; set; }
        [StringLength(45)]
        public string ConchaNasalInferiorDireitaDesc { get; set; }

        public int LacrimalDireito { get; set; }
        [StringLength(45)]
        public string LacrimalDireitoDesc { get; set; }

        public int NasalDireito { get; set; }
        [StringLength(45)]
        public string NasalDireitoDesc { get; set; }

        public int ZigomaticoDireito { get; set; }
        [StringLength(45)]
        public string ZigomaticoDireitoDesc { get; set; }

        public int Hioide { get; set; }
        [StringLength(45)]
        public string HioideDesc { get; set; }

        public int CartilagemTireoide { get; set; }
        [StringLength(45)]
        public string CartilagemTireoideDesc { get; set; }

        public int Mandibula { get; set; }
        [StringLength(45)]
        public string MandibulaDesc { get; set; }

        [StringLength(45)]
        public string Observacoes { get; set; }

        [StringLength(45)]
        public string FotosCranio { get; set; }

        // Relação com a entidade Relatorio
        //[ForeignKey("RelatorioId")]
        public virtual Relatorio Relatorio { get; set; }

        // Relação com a entidade InventarioEsqueleto        
        public virtual InventarioEsqueleto InventarioEsqueleto { get; set; }
        public virtual List<MarcadoresCranio> MarcadoresCranio { get; set; }

    }
}