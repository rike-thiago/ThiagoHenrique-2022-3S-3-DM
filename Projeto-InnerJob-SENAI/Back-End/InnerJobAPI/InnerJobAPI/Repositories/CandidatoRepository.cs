using InnerJobAPI.Contexts;
using InnerJobAPI.Domains;
using InnerJobAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InnerJobAPI.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        InnerJobContext ctx = new InnerJobContext();
        public void AtualizarIdUrl(int idCandidato, Candidato candidatoAtualizado)
        {
            Candidato candidatoBuscado = ctx.Candidatos.Find(idCandidato);

            if (candidatoBuscado.IdUsuario != 0 &&  candidatoBuscado.IdNotificacao != 0 
                && candidatoBuscado.Nome != null
                && candidatoBuscado.Telefone != null
                && candidatoBuscado.AreaAtuante != null)
            {
                candidatoBuscado.IdUsuario = candidatoAtualizado.IdUsuario;
                candidatoBuscado.IdNotificacao = candidatoAtualizado.IdNotificacao;
                candidatoBuscado.Nome = candidatoAtualizado.Nome;
                candidatoBuscado.Telefone = candidatoAtualizado.Telefone;
                candidatoBuscado.AreaAtuante = candidatoAtualizado.AreaAtuante;
            }

            ctx.Candidatos.Update(candidatoBuscado);

            ctx.SaveChanges();
        }

        public Candidato BuscarPorId(int idCandidato)
        {
            return ctx.Candidatos.FirstOrDefault(p => p.IdCandidato == idCandidato);
        }

        public void Cadastrar(Candidato novoCandidato)
        {
            ctx.Candidatos.Add(novoCandidato);

            ctx.SaveChanges();
        }

        public void DeletarPorId(int idCandidato)
        {
            Candidato candidatoBuscado = ctx.Candidatos.Find(idCandidato);

            ctx.Candidatos.Remove(candidatoBuscado);

            ctx.SaveChanges();
        }

        public List<Candidato> ListarTodos()
        {
            return ctx.Candidatos.ToList();
        }
    }
}
