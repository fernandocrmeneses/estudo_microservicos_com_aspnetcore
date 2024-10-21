using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.API.Application.DTO
{
    public class TemplatesDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; }
        public List<PaginaDTO> Pagina { get; set; }
    }
}
