using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Application.ViewModels
{
    public class TemplatesViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; }
        public List<PaginaViewModel> Pagina { get; set; }
    }
}
