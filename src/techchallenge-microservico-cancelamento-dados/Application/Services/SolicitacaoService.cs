using Application.Services.Interfaces;
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
            solicitacaoRepository = _solicitacaoRepository;
        }
    }
}
