﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Auth.Api.ViewModels
{
    public class UsuarioToken
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<UsuarioClaim> Claims { get; set; }
    }
}
