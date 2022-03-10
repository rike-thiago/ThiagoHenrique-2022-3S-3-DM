using System;
using System.Collections.Generic;

#nullable disable

namespace InnerJobAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Candidatos = new HashSet<Candidato>();
            Empresas = new HashSet<Empresa>();
            Oferta = new HashSet<Ofertum>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Candidato> Candidatos { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<Ofertum> Oferta { get; set; }
    }
}
