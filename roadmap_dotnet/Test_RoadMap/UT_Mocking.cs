using Moq;
using FluentAssertions;
using roadmap_dotnet.DesignPatterns.Strategy.Implementacoes;
using roadmap_dotnet.DesignPatterns.Strategy.Interfaces;
using roadmap_dotnet.Mocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_RoadMap
{
    public class UT_Mocking
    {
        private Mock<IServicoConsultaCredito> mock;       

        public UT_Mocking()
        {
            mock = new(MockBehavior.Strict);

            mock.Setup(s => s.ConsultarPendenciasPorCPF(TestUtils.CPF_INVALIDO))
                .Returns(() => null);

            mock.Setup(s => s.ConsultarPendenciasPorCPF(TestUtils.CPF_ERRO_COMUNICACAO))
                .Throws(exception: new("Testando erro de comunicação"));

            mock.Setup(s => s.ConsultarPendenciasPorCPF(TestUtils.CPF_SEM_PENDENCIAS))
                .Returns(() => new List<Pendencia>());
            var pendencias = new List<Pendencia>()
            {
                new ()
                {
                    CPF = TestUtils.CPF_INADIMPLENTE,
                    NomePessoa = "Cliente Teste",
                    NomeReclamante = "Empresas ACME",
                    DescricaoPendencia = "Parcela não paga",
                    VlPendencia = 900.50
                }
            };

            mock.Setup(s => s.ConsultarPendenciasPorCPF(TestUtils.CPF_INADIMPLENTE))
                .Returns(() => pendencias);
        }

        private StatusConsultaCredito ObterStatusAnaliseCredito(string cpf)
        {
            AnaliseCredito analise = new(mock.Object);
            return analise.ConsultarSituacaoCPF(cpf);
        }

        [Fact]
        [Trait("CPF Invalido", "Simular")]
        public void TestarCPFInvalidoMoq()
        {
            StatusConsultaCredito status =
                ObterStatusAnaliseCredito(TestUtils.CPF_INVALIDO);
            status.Should().Be(StatusConsultaCredito.ParametroEnvioInvalido,
                "Resultado incorreto para um CPF inválido");
        }

        [Fact]
        [Trait("Erro Comunicacao", "Simular")]
        public void TestarErroComunicacaoMoq()
        {
            StatusConsultaCredito status =
                ObterStatusAnaliseCredito(TestUtils.CPF_ERRO_COMUNICACAO);
            status.Should().Be(StatusConsultaCredito.ErroComunicacao,
                "Resultado incorreto para um erro de comunicação");
        }

        [Fact]
        [Trait("Sem Pendencias", "Simular")]
        public void TestarCPFSemPendenciasMoq()
        {
            StatusConsultaCredito status =
                ObterStatusAnaliseCredito(TestUtils.CPF_SEM_PENDENCIAS);
            status.Should().Be(StatusConsultaCredito.SemPendencias,
                "Resultado incorreto para um CPF sem pendências");
        }

        [Fact]
        [Trait("Inadimplente", "Simular")]
        public void TestarCPFInadimplenteMoq()
        {
            StatusConsultaCredito status =
                ObterStatusAnaliseCredito(TestUtils.CPF_INADIMPLENTE);
            
            
            status.Should().Be(StatusConsultaCredito.Inadimplente,
                "Resultado incorreto para um CPF inadimplente");
        }
    }
}
