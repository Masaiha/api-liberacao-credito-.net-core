using AutoMapper;
using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.Domain.Models;

namespace Inst.Financeiro.Application.AutoMapper
{
    public class ModelToViewModelProfile : Profile
    {
        public ModelToViewModelProfile()
        {
            CreateMap<CreditoViewModel, Credito>();
            CreateMap<ParcelaViewModel, Parcela>();
        }
    }
}
