using BaseProject.Application.DataTransferObjects.Teste;
using BaseProject.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ITesteAppService _testeAppService;

        public TesteController(ITesteAppService testeAppService)
        {
            _testeAppService = testeAppService;
        }

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public IActionResult Create(TestePostDto testePostDto)
        {
            var validationAppResult = _testeAppService.Add(testePostDto);

            if (!validationAppResult.IsValid)
                return BadRequest(validationAppResult.Erros);
            
            return NoContent();
        }

        [HttpGet]
        [Route("all")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            var testeGetDto = _testeAppService.GetAllReadOnly();
            return Ok(testeGetDto);
        }
    }
}