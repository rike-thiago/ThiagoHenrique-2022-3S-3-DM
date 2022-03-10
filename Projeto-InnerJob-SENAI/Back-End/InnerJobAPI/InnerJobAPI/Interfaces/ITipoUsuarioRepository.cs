using InnerJobAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJobAPI.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> ListarTodos();
        public TipoUsuario BuscarPorId(int idTipoUsuario);
        void Cadastrar(TipoUsuario novoTipoUsuario);
        void DeletarPorId(int idTipoUsuario);
        void AtualizarIdUrl(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizado);
    }
}
