using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace programa.Controllers
{
    //dizer que a classe é um Controller
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {
        private readonly ILogger<CalculoController> _logger;

        //construtor de controller
        public CalculoController(ILogger<CalculoController> logger)
        {
            _logger = logger;
        }

        //método para enviar informações
        [HttpPost]
        public String Post(string ru)
        {
            //armazenando posições da RU do aluno
            var a = Math.Pow(int.Parse(ru.ElementAt(ru.Length - 3).ToString()), 2);
            var b = Math.Pow(int.Parse(ru.ElementAt(ru.Length - 2).ToString()), 2);
            var c = Math.Pow(int.Parse(ru.ElementAt(ru.Length - 1).ToString()), 2);
            var resultado = "A equação de pitagoras equivale a " + a;

            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),

                WriteIndented = true
            };

            //passando informações para o arquivo
            return JsonSerializer.Serialize(resultado, options);
        }   
    }
}
