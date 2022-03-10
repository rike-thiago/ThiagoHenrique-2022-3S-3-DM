using System;
using System.Collections.Generic;

#nullable disable

namespace InnerJobAPI.Domains
{
    public partial class Notificação
    {
        public Notificação()
        {
            Candidatos = new HashSet<Candidato>();
        }

        public int IdNotificacao { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string TituloDescricao { get; set; }
        public DateTime? DataNotificacao { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Candidato> Candidatos { get; set; }
    }
}
