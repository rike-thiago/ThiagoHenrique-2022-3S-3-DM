using InnerJobAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJobAPI.Interfaces
{
    interface INotificaçãoRepository
    {
        List<Notificação> ListarTodos();
        public Notificação BuscarPorId(int idNotificação);
        void Cadastrar(Notificação novaNotificação);
        void DeletarPorId(int idNotificação);
        void AtualizarIdUrl(int idNotificação, Notificação notificaçãoAtualizado);
    }
}
