using CmsProject.Catalogo.Api.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CmsProject.Presentation.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiTeste : ControllerBase
    {
        //private readonly ICatalogoQueries _catalogoQueries;
        public ApiTeste()
        {
            
        }

        [HttpGet]
        public void Get()
        {

        }
    }
}
