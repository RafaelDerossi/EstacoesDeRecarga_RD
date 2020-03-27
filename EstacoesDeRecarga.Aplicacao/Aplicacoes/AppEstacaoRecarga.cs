using EstacaoDeRecarga.Dominio.Modelos;
using EstacaoDeRecarga.Dominio.Interfaces;
using EstacoesDeRecarga.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EstacaoDeRecarga.Aplicacao.ViewModel;
using System.Linq;

namespace EstacaoDeRecarga.Aplicacao.Aplicacoes
{
    public class AppEstacaoRecarga : IAppEstacaoRecarga
    {
        private readonly IRepositorioEstacaoRecarga _RepositorioEstacaoRecarga;
        private readonly IMapper _mapper;

        public AppEstacaoRecarga(IRepositorioEstacaoRecarga repositorioEstacaoRecarga, IMapper mapper)
        {
            _RepositorioEstacaoRecarga = repositorioEstacaoRecarga;
            _mapper = mapper;
        }



        public void Adicionar(EstacaoRecargaViewModel obj)
        {
            try
            {
                var estacao = _mapper.Map<EstacaoRecarga>(obj);
                _RepositorioEstacaoRecarga.Adicionar(estacao);                
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public void Atualizar(EstacaoRecargaViewModel obj)
        {
            var estacao = _mapper.Map<EstacaoRecarga>(obj);
            _RepositorioEstacaoRecarga.Atualizar(estacao);
        }

        public void Excluir(EstacaoRecargaViewModel obj)
        {
            var estacao = _mapper.Map<EstacaoRecarga>(obj);
            _RepositorioEstacaoRecarga.Excluir(estacao);
        }

        public IList<EstacaoRecargaViewModel> Listar()
        {
            var estacoes = _RepositorioEstacaoRecarga.Listar();
            EstacaoRecargaViewModel estacao;
            var estacoesViewModel = new List<EstacaoRecargaViewModel>();
            foreach (EstacaoRecarga item in estacoes)
            {
                estacao = _mapper.Map<EstacaoRecargaViewModel>(item);
                estacoesViewModel.Add(estacao);
            }            
            return estacoesViewModel;
        } 

        public EstacaoRecargaViewModel RecuperarPorId(Guid id)
        {
            var estacao = _mapper.Map<EstacaoRecargaViewModel>(_RepositorioEstacaoRecarga.RecuperarPorId(id));
            return estacao;
        }
       
    }
}
