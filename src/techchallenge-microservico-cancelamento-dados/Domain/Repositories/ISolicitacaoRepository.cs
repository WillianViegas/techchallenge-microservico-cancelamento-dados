using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISolicitacaoRepository
    {
        public Task SaveSolicitacao(Solicitacao solicitacaoObj);
        public Task<List<Solicitacao>> GetAllSolicitacoes();
        public Task<Solicitacao> GetSolicitacaoById(string id);
    }
}
