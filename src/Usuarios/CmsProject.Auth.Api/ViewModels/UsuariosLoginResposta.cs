using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Auth.Api.ViewModels
{
    public class UsuariosLoginResposta
    {
        public string AccessToken { get; set; }
        public double ExpiresIn { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
    }
}
