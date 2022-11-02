using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    //cabeçalho basico para iniciar um controlador
    [ApiController]
    [Route("[controller]")]
    //o nome da classe antes do Controller é automaticamente pego para fazer o link de caminho até o metodo.
    public class UsuarioController : ControllerBase
    {
        //esse cabeçalho diz o nome do metodo no caminho do link.
        //exemplo: https://localhost:7257/Usuario/ObterDataHoraAtual
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }
    }
}