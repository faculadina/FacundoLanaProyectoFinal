using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpPut]

        public void modificarUsuario(Usuario usuario)
        {
            UsuarioHandler.modificarUsuario(usuario);
        }


        [HttpGet("{nombreUsuario}/{contrasena}")]
        public Usuario login(string nombreUsuario, string contrasena)
        {
           return UsuarioHandler.inicioDeSesion(nombreUsuario, contrasena);
        }

        [HttpPost]
        public void crearUsuario([FromBody] Usuario user)
        {
            UsuarioHandler.crearUsuario(user);
        }

        [HttpGet("{idUsuario}")]

        public Usuario traerUsuario(long idUsuario)
        {
            return UsuarioHandler.ConsultarUsuario(idUsuario);
        }

        [HttpDelete("{idUsuario}")]
        public void eliminarUsuario(long idUsuario)
        {
            UsuarioHandler.eliminarUsuario(idUsuario);
        }
        
    }
}
