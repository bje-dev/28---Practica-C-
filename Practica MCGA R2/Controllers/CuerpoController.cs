using Microsoft.AspNetCore.Mvc;
using Practica_MCGA_R2.Modelos;

namespace Practica_MCGA_R2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class CuerpoController : Controller
    {
        public static Random random = new Random();

        [HttpGet]
        [Route("resultado")]
        public IActionResult GetCuerpo() 
        
        {
            Cuerpo _cuerpo = default;

            var tipo = new string[] { "estrella", "planeta", "satelite" };
            var temperatura = new double[] { 100, 200, 300 };
            var tamaño = random.Next(1000, 9100);
            var distancia = new int[] { 2500, 3600, 4988, 8542 };

            _cuerpo = new Cuerpo();

            _cuerpo.tipo = tipo[random.Next(tipo.Length)];
            _cuerpo.temperatura = temperatura[random.Next(temperatura.Length)];
            _cuerpo.tamaño = tamaño;
            _cuerpo.distancia = distancia[random.Next(distancia.Length)];


            
                return Ok(_cuerpo);
                       


        }
        
       
    }
}
