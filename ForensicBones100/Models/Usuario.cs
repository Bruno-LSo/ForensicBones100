using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones100.Models
{
        [Table("Usuarios")]
        public class Usuario
        {
            [Key]
            public int UsuarioId { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome")]
            [StringLength(45)]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Insira um e-mail válido")]
            [Display(Name = "E-mail")]
            [StringLength(45)]
            public string Email { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a senha")]
            [DataType(DataType.Password)]
            [StringLength(45)]
            public string Senha { get; set; }

            [StringLength(45)]
            public string Cargo { get; set; }
        }
}