using System;
using System.Collections.Generic;

#nullable disable

namespace InnerJobAPI.Domains
{
    public partial class Candidato
    {
        public int IdCandidato { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdNotificacao { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string AreaAtuante { get; set; }

        public virtual Notificação IdNotificacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
