using Amazon.Runtime.Internal.Util;
using Application.Services;
using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Logging;
using Moq;
using tech_ms_cancelamento_dados.Controllers;

namespace tech_ms_cancelamento_dados_test.Repositories
{
    public class SolicitacaoRepositoryTests
    {
        [Fact]
        public void GetAllSolicitacoes()
        {
            //arrange

            var solicitacao1 = GetSolicitacaoObj();
            var solicitacao2 = GetSolicitacaoObj();

            var solicitacaoList = new List<Solicitacao>
            {
                solicitacao1,
                solicitacao2
            };

            var solicitacaoRepository = new Mock<ISolicitacaoRepository>().Object;

            Mock.Get(solicitacaoRepository)
           .Setup(service => service.GetAllSolicitacoes())
           .ReturnsAsync(solicitacaoList);


            //act
            var result = solicitacaoRepository.GetAllSolicitacoes();

            //assert
            Assert.NotNull(result);

        }

        [Fact]
        public void GetSolicitacaoById()
        {
            //arrange
            var solicitacao1 = GetSolicitacaoObj();
            solicitacao1.Id = "39jr94j94r94ksd9k";
            
            var solicitacaoRepository = new Mock<ISolicitacaoRepository>().Object;
            Mock.Get(solicitacaoRepository)
           .Setup(service => service.GetSolicitacaoById(solicitacao1.Id))
           .ReturnsAsync(solicitacao1);


            //act
            var result = solicitacaoRepository.GetSolicitacaoById(solicitacao1.Id);

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public void SalvarSolicitacao()
        {
            //arrange
            var solicitacao1 = GetSolicitacaoObj();
            var solicitacaoRepository = new Mock<ISolicitacaoRepository>().Object;

            Mock.Get(solicitacaoRepository)
           .Setup(service => service.SaveSolicitacao(solicitacao1)).Verifiable();


            //act
            var result = solicitacaoRepository.SaveSolicitacao(solicitacao1);

            //assert
            Assert.NotNull(result);
        }

        private Solicitacao GetSolicitacaoObj()
        {
            var solicitacao = new Solicitacao();
            var usuario = new UsuarioInfo()
            {
                Nome = "Jose Teste",
                Endereco = "Rua alameda bastos, 550",
                NumeroTelefone = "11 99999-9999"
            };

            solicitacao.UsuarioInfo = usuario;
            solicitacao.DataCriacao = DateTime.Now;

            return solicitacao;
        }

        private SolicitacaoController ConfigMockSolicitacaoController(ISolicitacaoService solicitacaoService)
        {
            var mock = new Mock<ILogger<SolicitacaoController>>();
            ILogger<SolicitacaoController> logger = mock.Object;

            var controller = new SolicitacaoController(logger, solicitacaoService);

            return controller;
        }
    }
}