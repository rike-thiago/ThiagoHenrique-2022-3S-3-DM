using InnerJobAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJobAPI.Interfaces
{
    interface IEmpresaRepository
    {
        List<Empresa> ListarTodos();
        public Empresa BuscarPorId(int idEmpresa);
        void Cadastrar(Empresa novaEmpresa);
        void DeletarPorId(int idEmpresa);
        void AtualizarIdUrl(int idEmpresa, Empresa empresaAtualizada);
    }
}
