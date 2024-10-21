using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;



namespace CmsProject.Auth.Api.ViewModels
{
    public class UsuariosViewModel : IdentityUser
    {
        //[Key]
        //public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, long.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public long CPF_CNPJ { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Status { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }

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
