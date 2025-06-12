using JogoDaOncinha.Interfaces;
using JogoDaOncinha.Models;
using JogoDaOncinha.Repositories;
using System.Collections.Generic;

namespace JogoDaOncinha.Services
{
    // Camada de serviço específica para regras de negócio de usuários
    public class UsuarioService
    {
        private readonly IRepository<Usuario> _usuarioRepository;


        // Construtor que injeta o repositório de usuários.
        // O _usuarioRepository é uma interface que representa um repositório para lidar com o banco de dados.
        public UsuarioService(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void DeletarUsuario(int id)
        {
            _usuarioRepository.Delete(id);
        }
    }
}
