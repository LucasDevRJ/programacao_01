using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace programa.Controllers
{
    //dizer que a classe é um Controller
    [ApiController]
    [Route("[controller]")]

    //herando de controller classe
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        //construtor de controller
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //método para pegar informações
        [HttpGet]
        public String Get()
        {
            //instanciando aluno
            var aluno = new Aluno
            {
                //armazenando informações
                nome = "Lucas Pereira de Lima",
                ru = "3658733"
            };
            //passando informações para o arquivo
            return JsonSerializer.Serialize(aluno);
        }
    }
}
