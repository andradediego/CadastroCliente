using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroUsuarios.Interfaces;
using AutoMapper;
using CadastroUsuarios.Dtos;
using CadastroUsuarios.Entities;

namespace CadastroUsuarios.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UsuariosController : Controller
    {
        private IUsuariosRepository _usuariosRepository;

        public UsuariosController(IUsuariosRepository usuariosRepository)
        {
            this._usuariosRepository = usuariosRepository;
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody]UsuariosDto usuarioDto)
        {
            return InserirOuAtualizarUsuario(usuarioDto);
        }

        [HttpPost]
        public IActionResult ConsultarUsuario([FromBody]ConsultarUsuarioDto consulta)
        {
            if(string.IsNullOrWhiteSpace(consulta.Nome) && string.IsNullOrWhiteSpace(consulta.CPF))
                return NotFound();

            var usuario = _usuariosRepository.Selecionar(consulta.Nome, consulta.CPF);

            if (usuario == null)
                return NotFound();

            return Ok(Mapper.Map<UsuariosDto>(usuario));
        }

        [HttpPost]
        public IActionResult DeletarUsuario([FromBody]UsuariosDto u)
        {
            if(!u.Id.HasValue)
                return NotFound();

            var usuario = _usuariosRepository.SelecionarSimples(u.Id.Value);

            if(usuario == null)
                return NotFound();

            _usuariosRepository.Deletar(u.Id.Value);

            var resultado = _usuariosRepository.SalvarAtualizacoes();

            if(!resultado)
                throw new Exception($"Aconteceu algo inesperado ao tentar deletar o usuário de id: {u.Id.Value}");

            return NoContent();
        }

        [HttpPost]
        public IActionResult AtualizarUsuario([FromBody]UsuariosDto usuarioDto)
        {
            return InserirOuAtualizarUsuario(usuarioDto);
        }

        private IActionResult InserirOuAtualizarUsuario(UsuariosDto usuarioDto)
        {
            if (usuarioDto == null)
                return BadRequest("Usuário nulo ou inválido");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (usuarioDto.CPFValido())
            {
                var usuario = Mapper.Map<Usuarios>(usuarioDto);

                if(usuario.Id.HasValue)
                    _usuariosRepository.Atualizar(usuario);
                else
                    _usuariosRepository.Adicionar(usuario);

                var resultado = _usuariosRepository.SalvarAtualizacoes();

                if (!resultado)
                    throw new Exception($"Aconteceu algo inesperado");

                return Ok(Mapper.Map<UsuariosDto>(usuario));
            }
            else
                return BadRequest("CPF inválido");
        }
    }
}
