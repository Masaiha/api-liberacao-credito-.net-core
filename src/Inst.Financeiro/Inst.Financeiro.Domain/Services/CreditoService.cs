using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Services
{
    public class CreditoService : BaseService<Credito>, ICreditoService
    {
        private readonly IParcelaRepository _parcelaRepository;
        private readonly ICreditoRepository _repository;
        private readonly ITaxaRepository _taxaRepository;

        public CreditoService(ICreditoRepository repository,
                              INotificador notificador,
                              IParcelaRepository parcelaRepository, 
                              ITaxaRepository taxaRepository) : base(notificador)
        {
            _repository = repository;
            _parcelaRepository = parcelaRepository;
            _taxaRepository = taxaRepository;
        }

        public async Task<Credito> ObterPorCliente(int id)
        {
            return await _repository.ObterPorCliente(id);
        }

        public async Task Adicionar(Credito credito)
        {
            ValidarCredito(credito);

            if (TemNotificacao())
                return;

            credito.Id = await _repository.ObterUltimoId();
            credito.Aprovado = true;
            credito.Status = true;

            await AdicionarParcelas(credito);
            await _repository.Adicionar(credito);
        }

        private async Task AdicionarParcelas(Credito credito)
        {
            for (int i = 1; i <= credito.QuantidadeParcelas; i++)
            {
                await _parcelaRepository.Adicionar(new Parcela()
                {
                    Id = Guid.NewGuid(),
                    IdCredito = credito.Id,
                    Vencimento = CalcularDataVencimentoParcela(credito, i),
                    Numero = i,
                    ValorCalculado = await CalcularValorParcela(credito)
                });
            }
        }

        private DateTime CalcularDataVencimentoParcela(Credito credito, int indice)
        {
            return indice == 1 ? credito.DataPrimeiraParcela : credito.DataPrimeiraParcela.AddDays((indice - 1) * 30);
        }

        private async Task<decimal> CalcularValorParcela(Credito credito)
        {
            return (credito.ValorCredito / decimal.Parse(credito.QuantidadeParcelas.ToString())) * await _taxaRepository.ObterTaxaPorTipoCredito(credito.Tipo);
        }

        private void ValidarCredito(Credito credito)
        {
            ValidarValorCredito(credito);
            ValidarQuantidadeParcelas(credito);
            ValidarDataPrimeiraParcela(credito);
        }

        private void ValidarValorCredito(Credito credito)
        {
            if (credito.ValidarValorCredito())
            {
                Notificar("Valor crédito está fora da range de valores permitidos");
            }
        }

        private void ValidarQuantidadeParcelas(Credito credito)
        {
            if (credito.ValidarQuantidadeParcelas())
            {
                Notificar("Quantidade de parcelas deve ser entre 5 e 75 parcelas");
            }
        }

        private void ValidarDataPrimeiraParcela(Credito credito)
        {
            if (!credito.ValidarDataPrimeiraParcela())
            {
                Notificar("A data da primeira parcela deve ser de no mínimo 15 dias futuros");
            }
        }
    }
}
