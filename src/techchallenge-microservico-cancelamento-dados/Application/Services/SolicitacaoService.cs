using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SolicitacaoService : ISolicitacaoService
    {
        private readonly ISolicitacaoRepository _solicitacaoRepository;

        public SolicitacaoService(ISolicitacaoRepository solicitacaoRepository)
        {
            _solicitacaoRepository = solicitacaoRepository;
        }

        public async Task<List<Solicitacao>> GetAllSolicitacoes()
        {
            return await _solicitacaoRepository.GetAllSolicitacoes();
        }

        public async Task<Solicitacao> GetSolicitacaoById(string id)
        {
            return await _solicitacaoRepository.GetSolicitacaoById(id);
        }

        public async Task SaveSolicitacao(Solicitacao solicitacaoObj)
        {
           await _solicitacaoRepository.SaveSolicitacao(solicitacaoObj);
        }
    }
}
