using System;
using System.Collections.Generic;

#nullable disable

namespace InnerJobAPI.Domains
{
    public partial class Ofertum
    {
        public int IdOferta { get; set; }
        public int? IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
