using System;
using System.Collections.Generic;

#nullable disable

namespace InnerJobAPI.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Notificaçãos = new HashSet<Notificação>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string TituloTipoUsuario { get; set; }

        public virtual ICollection<Notificação> Notificaçãos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
