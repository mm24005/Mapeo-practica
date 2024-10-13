using AutoMapper;
using Mapeo_practica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsuariosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDTO> ObtenerUsuario(int id)
        {
            // Simular la obtención de un usuario (en una aplicación real, obtener de la base de datos)
            var usuario = new Usuario { Id = id, Nombre = "Juan Pérez" };

            // Mapear a UsuarioDto
            var usuarioDto = _mapper.Map<UsuarioDTO>(usuario);

            return Ok(usuarioDto);
        }
    }
}