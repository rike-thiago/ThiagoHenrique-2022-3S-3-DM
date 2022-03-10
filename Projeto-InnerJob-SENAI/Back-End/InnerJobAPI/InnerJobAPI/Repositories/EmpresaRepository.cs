using InnerJobAPI.Contexts;
using InnerJobAPI.Domains;
using InnerJobAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace InnerJobAPI.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        InnerJobContext ctx = new InnerJobContext();
        public void AtualizarIdUrl(int idEmpresa, Empresa empresaAtualizada)
        {
            Empresa empresaBuscada = ctx.Empresas.Find(idEmpresa);

            if (empresaBuscada.IdUsuario != 0
                && empresaBuscada.Nome != null
                && empresaBuscada.Cnpj != null
                && empresaBuscada.Ramo != null)
            {
                empresaBuscada.IdUsuario = empresaAtualizada.IdUsuario;
                empresaBuscada.Nome = empresaAtualizada.Nome;
                empresaBuscada.Cnpj = empresaAtualizada.Cnpj;
                empresaBuscada.Ramo = empresaAtualizada.Ramo;
            }

            ctx.Empresas.Update(empresaBuscada);

            ctx.SaveChanges();
        }

        public Empresa BuscarPorId(int idEmpresa)
        {
            return ctx.Empresas.FirstOrDefault(p => p.IdEmpresa == idEmpresa);
        }

        public void Cadastrar(Empresa novaEmpresa)
        {
            ctx.Empresas.Add(novaEmpresa);

            ctx.SaveChanges();
        }

        public void DeletarPorId(int idEmpresa)
        {
            Empresa empresaBuscada = ctx.Empresas.Find(idEmpresa);

            ctx.Empresas.Remove(empresaBuscada);

            ctx.SaveChanges();
        }

        public List<Empresa> ListarTodos()
        {
            return ctx.Empresas.ToList();
        }
    }
}
