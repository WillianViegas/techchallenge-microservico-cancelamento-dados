using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace tech_ms_cancelamento_dados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolicitacaoController : Controller
    {
        private readonly ILogger<SolicitacaoController> _logger;
        private ISolicitacaoService _solicitacaoService;

        public SolicitacaoController(ILogger<SolicitacaoController> logger, ISolicitacaoService solicitacaoService)
        {
            _logger = logger;
            _solicitacaoService = solicitacaoService;
        }

        [HttpGet("/teste")]
        public IResult Teste()
        {
            try
            {
                return TypedResults.Ok("Teste");
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IResult> SalvarSolicitacao(Solicitacao solicitacao)
        {
            try
            {
                await _solicitacaoService.SaveSolicitacao(solicitacao);
                return TypedResults.Created($"Solicitação gerada!");
            }
            catch(Exception ex)
            {
                var erro = $"Erro ao criar a solicitação.";
                _logger.LogError(erro, ex);
                return TypedResults.Problem(erro);
            }
        }

        [HttpGet]
        public async Task<IResult> GetAllSolicitacoes()
        {
            try
            {
                var listaSolicitacoes = await _solicitacaoService.GetAllSolicitacoes();
                return TypedResults.Ok(listaSolicitacoes);
            }
            catch(Exception ex)
            {
                var erro = $"Erro ao buscar lista de solicitações.";
                _logger.LogError(erro, ex);
                return TypedResults.Problem(erro);
            }
        }

        [HttpGet("/{id}")]
        public async Task<IResult> GetSolicitacaoById(string id)
        {
            try
            {
                var solicitacao = await _solicitacaoService.GetSolicitacaoById(id);
                return TypedResults.Ok(solicitacao);
            }
            catch (Exception ex)
            {
                var erro = $"Erro ao buscar solicitação.";
                _logger.LogError(erro, ex);
                return TypedResults.Problem(erro);
            }
        }
    }
}
