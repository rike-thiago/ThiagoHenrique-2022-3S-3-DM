using System;
using System.Collections.Generic;

#nullable disable

namespace InnerJobAPI.Domains
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public int? IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Ramo { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
