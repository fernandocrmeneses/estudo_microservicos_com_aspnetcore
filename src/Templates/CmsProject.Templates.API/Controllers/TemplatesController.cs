using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmsProject.WebApi.Core.Controllers;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Templates.API.Application.Commands;
using CmsProject.Templates.Application.ViewModels;
using CmsProject.Templates.API.Application.DTO;

namespace CmsProject.Templates.API.Controllers
{
    public class TemplatesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;


        public TemplatesController(IMediatorHandler mediatorHandler)
        {

            _mediatorHandler = mediatorHandler;
        }


        //[HttpGet("templates")]
        //public IEnumerable<string> Index()
        //{
        //    return new string[] { "ola mundo", "api-templates" };
        //}

        // POST: Templates/Create
        [HttpPost("AddPagina")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaginaDTO pagina)
        {
            try
            {
                var resultado = await _mediatorHandler.EnviarComando(
                new AdicionarPaginaCommand(Guid.NewGuid(), pagina.IdUsuario,
                pagina.DataCriacao,
                pagina.DataAtualizacao,
                pagina.Header,
                pagina.Menu,
                pagina.Body,
                pagina.Footer,
                pagina.Nome,
                pagina.Categoria,
                pagina.ElementoFrontEnd,
                pagina.Imagens,
                pagina.TemplatesId,
                pagina.Status,
                pagina.WorkFlow));

                return CustomResponse();
            }
            catch
            {
                return CustomResponse();
            }
        }


        [HttpPost("adicionar")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var resultado = await _mediatorHandler.EnviarComando(
                new AdicionarTemplateCommand(Guid.NewGuid(), "", 1));

                return CustomResponse(resultado);
            }
            catch (Exception e)
            {
                return CustomResponse();
            }
        }

        [HttpGet("atualizar")]
        public async Task<IActionResult> Index(TemplatesDTO template)
        {
            try
            {
                var resultado = await _mediatorHandler.EnviarComando(
                new AdicionarTemplateCommand(Guid.NewGuid(), "", 1));

                return CustomResponse(resultado);
            }
            catch (Exception e)
            {
                return CustomResponse();
            }
        }
    }
}
