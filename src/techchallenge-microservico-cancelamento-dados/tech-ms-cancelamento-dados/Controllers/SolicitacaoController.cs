using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace tech_ms_cancelamento_dados.Controllers
{
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
    }
}
