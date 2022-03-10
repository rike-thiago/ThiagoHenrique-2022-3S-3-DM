using InnerJobAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJobAPI.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();
        public Usuario BuscarPorId(int idUsuario);
        void Cadastrar(Usuario novoUsuario);
        void DeletarPorId(int idUsuario);
        void AtualizarIdUrl(int idUsuario, Usuario usuarioAtualizado);
        
    }
}
