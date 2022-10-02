using Inst.Financeiro.CrossCutting.Enumerators;
using Inst.Financeiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inst.Financeiro.Infra.Context
{
    public static class BancoDados
    {
        static List<Credito> Creditos = new List<Credito>();
        static List<Parcela> Parcelas = new List<Parcela>();

        public static void DadosIniciais()
        {
            var credito1 = new Credito()
            {
                Id = 1,
                Tipo = TipoCredito.Consignado,
                Cliente = TipoCliente.PF,
                ValorCredito = 1000.00m,
                Aprovado = true,
                Status = true
            };

            credito1.SetValorCalculado();
            credito1.SetValorTaxa();

            Creditos.Add(credito1);

            Parcelas.Add(new Parcela()
            {
                Id = Guid.NewGuid(),
                IdCredito = 1,
                Numero = 1,
                ValorCalculado = 1100.00m,
                Vencimento = System.DateTime.Now
            });

            Parcelas.Add(new Parcela()
            {
                Id = Guid.NewGuid(),
                IdCredito = 1,
                Numero = 2,
                ValorCalculado = 1100.00m,
                Vencimento = System.DateTime.Now.AddDays(30)
            });

            Parcelas.Add(new Parcela()
            {
                Id = Guid.NewGuid(),
                IdCredito = 1,
                Numero = 3,
                ValorCalculado = 1100.00m,
                Vencimento = System.DateTime.Now.AddDays(60)
            });

            Parcelas.Add(new Parcela()
            {
                Id = Guid.NewGuid(),
                IdCredito = 1,
                Numero = 4,
                ValorCalculado = 1100.00m,
                Vencimento = System.DateTime.Now.AddDays(90)
            });

            Parcelas.Add(new Parcela()
            {
                Id = Guid.NewGuid(),
                IdCredito = 1,
                Numero = 5,
                ValorCalculado = 1100.00m,
                Vencimento = System.DateTime.Now.AddDays(120)
            });

            Parcelas.Add(new Parcela()
            {
                Id = Guid.NewGuid(),
                IdCredito = 2,
                Numero = 1,
                ValorCalculado = 2000.00m,
                Vencimento = System.DateTime.Now
            });
        }

        public static void TbCreditoAdicionar(Credito credito)
        {
            try
            {
                Creditos.Add(credito);

                return;
            }
            catch (System.Exception)
            {
                throw new System.Exception("Erro ao adicionar dados no banco");
            }
        }

        public static void TbParcelasAdicionar(Parcela parcela)
        {
            try
            {
                Parcelas.Add(parcela);

                return;
            }
            catch (System.Exception)
            {
                throw new System.Exception("Erro ao adicionar dados no banco");
            }
        }

        public static Credito TbCreditos(int idCredito)
        {
            var Credito = Creditos.Where(c => c.Id == idCredito).FirstOrDefault();

            Credito.Parcelas = Parcelas.Where(p => p.IdCredito == idCredito);

            return Credito;
        }

        public static int ProximoIdCredito()
        {
            return Creditos.LastOrDefault().Id + 1;
        }

        public static IEnumerable<Parcela> TbParcela()
        {
            return Parcelas;
        }

    }
}
