﻿using ForensicBones100.Models;
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
        [Display(Name = "Código do Relatório")]
        public int RelatorioMarcadoresId { get; set; }

        public char CristaNucal { get; set; }
        public char ProcessoMastoide { get; set; }
        public char EminenciaMentoniana { get; set; }
        public char SupraOrbital { get; set; }
        public char AreaGlabela { get; set; }
        public char CalculoEstimativaSexo { get; set; }

        public string Observacoes { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioMarcadoresId")]
        public virtual Relatorio Relatorio { get; set; }

    }
}