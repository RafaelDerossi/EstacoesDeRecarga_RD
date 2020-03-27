using AutoMapper;
using EstacaoDeRecarga.Aplicacao.ViewModel;
using EstacaoDeRecarga.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDeRecarga.Aplicacao.AutoMapper
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<EstacaoRecarga, EstacaoRecargaViewModel>();
            CreateMap<EstacaoRecargaViewModel, EstacaoRecarga>();
        }                   
    }
}
