using DI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController(IHelperService helperService) : ControllerBase
    {

        private readonly IHelperService _helperService = helperService;

        [HttpGet]
        public IActionResult SomaDoisNumeros(int valor1, int valor2)
        {
            var dados = _helperService.SomaDoisNumeros(valor1, valor2);
            return Ok(dados);
        }

    }
}
