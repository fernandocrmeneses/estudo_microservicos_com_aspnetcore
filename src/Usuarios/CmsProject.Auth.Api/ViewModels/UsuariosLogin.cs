using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace CmsProject.Auth.Api.ViewModels
{
    public class UsuariosLogin: IdentityUser
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }
    }
}
