using InnerJobAPI.Contexts;
using InnerJobAPI.Domains;
using InnerJobAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InnerJobAPI.Repositories
{
    public class NotificaçãoRepository : INotificaçãoRepository
    {
        InnerJobContext ctx = new InnerJobContext();
        public void AtualizarIdUrl(int idNotificação, Notificação notificaçãoAtualizado)
        {
            Notificação notificacaoBuscada = ctx.Notificaçãos.Find(idNotificação);
            DateTime dataNula = Convert.ToDateTime("01/01/0001");

            if (notificacaoBuscada.IdTipoUsuario != 0 
                && notificacaoBuscada.TituloDescricao != null
                && notificacaoBuscada.DataNotificacao != dataNula)
            {
                notificacaoBuscada.IdTipoUsuario = notificaçãoAtualizado.IdTipoUsuario;
                notificacaoBuscada.TituloDescricao = notificaçãoAtualizado.TituloDescricao;
                notificacaoBuscada.DataNotificacao = notificaçãoAtualizado.DataNotificacao;
            }

            ctx.Notificaçãos.Update(notificacaoBuscada);

            ctx.SaveChanges();
        }

        public Notificação BuscarPorId(int idNotificação)
        {
            return ctx.Notificaçãos.FirstOrDefault(p => p.IdNotificacao == idNotificação);
        }

        public void Cadastrar(Notificação novaNotificação)
        {
            ctx.Notificaçãos.Add(novaNotificação);

            ctx.SaveChanges();
        }

        public void DeletarPorId(int idNotificação)
        {
            Notificação notificacaoBuscada = ctx.Notificaçãos.Find(idNotificação);

            ctx.Notificaçãos.Remove(notificacaoBuscada);

            ctx.SaveChanges();
        }

        public List<Notificação> ListarTodos()
        {
            return ctx.Notificaçãos.ToList();
        }
    }
}
