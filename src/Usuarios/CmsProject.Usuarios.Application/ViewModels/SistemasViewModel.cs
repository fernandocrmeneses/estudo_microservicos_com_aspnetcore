using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CmsProject.Usuarios.Application.ViewModels
{
    public class SistemasViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Dominio { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Status { get; set; }
    }
}
