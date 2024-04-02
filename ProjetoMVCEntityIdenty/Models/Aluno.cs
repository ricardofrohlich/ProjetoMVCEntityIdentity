using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVCEntityIdenty.Models
{
    
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [EmailAddress]
        [Required, MaxLength(150)]
        public string Email { get; set; }
        public int? Idade { get; set; }
        public string? Curso { get; set; }
    }
}
