using InnerJobAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJobAPI.Interfaces
{
    interface IOfertaRepository
    {
        List<Ofertum> ListarTodos();
        public Ofertum BuscarPorId(int idOfertum);
        void Cadastrar(Ofertum novaOfertum);
        void DeletarPorId(int idOfertum);
        void AtualizarIdUrl(int idOfertum, Ofertum ofertumAtualizada);
    }
}
