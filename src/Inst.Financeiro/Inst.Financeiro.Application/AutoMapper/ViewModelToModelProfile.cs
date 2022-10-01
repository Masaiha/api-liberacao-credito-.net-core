using AutoMapper;
using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.Domain.Models;

namespace Inst.Financeiro.Application.AutoMapper
{
    public class ViewModelToModelProfile : Profile
    {
        public ViewModelToModelProfile()
        {
            CreateMap<PessoaFisicaViewModel, PessoaFisica>();
            CreateMap<PessoaJuridicaViewModel, PessoaJuridica>();
        }
    }
}
