using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {

        [HttpGet("{idUsuario}")]
        public List<ProductoVendido> traerProductosVendidos(long idUsuario)
        {
            return ProductoVendidoHandler.consultaProductosVendidos(idUsuario);
        }
    }
}
