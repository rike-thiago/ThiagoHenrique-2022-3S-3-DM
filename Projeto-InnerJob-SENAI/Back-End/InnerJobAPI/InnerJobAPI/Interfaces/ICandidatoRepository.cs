using InnerJobAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJobAPI.Interfaces
{
    interface ICandidatoRepository
    {
        List<Candidato> ListarTodos();
        public Candidato BuscarPorId(int idCandidato);
        void Cadastrar(Candidato novoCandidato);
        void DeletarPorId(int idCandidato);
        void AtualizarIdUrl(int idCandidato, Candidato candidatoAtualizado);
    }
}
