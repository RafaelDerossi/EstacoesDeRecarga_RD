using EstacaoDeRecarga.Dominio.Interfaces;
using EstacaoDeRecarga.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstacaoDeRecarga.Infra.Dados.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<EstacaoDeRegargaDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            _optionsBuilder = new DbContextOptions<EstacaoDeRegargaDbContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new EstacaoDeRegargaDbContext(_optionsBuilder))
            {
                try
                {
                    db.Set<T>().Add(obj);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new EstacaoDeRegargaDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new EstacaoDeRegargaDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IList<T> Listar()
        {
            using (var db = new EstacaoDeRegargaDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new EstacaoDeRegargaDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Dispose()
        {         
        }
    }
}
