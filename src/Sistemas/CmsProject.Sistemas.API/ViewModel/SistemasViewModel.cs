using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Sistemas.API.ViewModel
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
