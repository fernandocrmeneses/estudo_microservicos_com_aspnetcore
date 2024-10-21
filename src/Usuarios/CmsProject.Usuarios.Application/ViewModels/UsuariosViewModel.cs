using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CmsProject.Usuarios.Application.ViewModels
{
    public class UsuariosViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SobreNome { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF_CNPJ { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Status { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCriacao { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCancelamento { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataRetorno { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int TipoUsuario { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid IdSistema { get; set; }
    }
}
