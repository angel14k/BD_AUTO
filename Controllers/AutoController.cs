
using BD_AUTO.BLL;
using BD_AUTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace BD_AUTO.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AutoController : ControllerBase
    {

        private readonly AutoBLL autoBLL;
        public AutoController(AutoBLL autoBLL)
        {
            this.autoBLL = autoBLL;
        }

        [HttpGet]
        public List<Auto> Listar()
        {
            return autoBLL.Listar();

        }

        [HttpGet("id")]
        public Auto Buscar(int id)
        {
            return autoBLL.Buscar(id);
        }

        [HttpPost]
        public IActionResult Insertar(Auto auto)
        {
            autoBLL.Insertar(auto);

            return Ok("Auto Insertado correctamente, JEFE ANGEL");
        }


        [HttpPut]
        public IActionResult Actualizar(Auto auto)
        {
            autoBLL.Actualizar(auto);

            return Ok("Auto Actualizado correctamente, JEFE ANGEL");
        }

        [HttpDelete]
        public IActionResult Eliminar(int id)
        {
            autoBLL.Eliminar(id);

            return Ok("Auto Eliminado correctamente , JEFE ANGEL");
        }
    }
}
