using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDeRecarga.Dominio.Interfaces
{
  public  interface IRepositorioBase<T> where T : class
    {
        void Adicionar(T obj);

        T RecuperarPorId(Guid id);

        void Atualizar(T obj);

        void Excluir(T obj);

        IList<T> Listar();
    }
}
