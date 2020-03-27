using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EstacaoDeRecarga.Dominio.ObjetosDeValor
{
    
    public class TipoEstacao : ObjetoDeValor<TipoEstacao>
    {        
        public string Descricao { get; set; }
             
        public TipoEstacao(string descricao)
        {
            Descricao = descricao;
        }

        public static IEnumerable<TipoEstacao> TiposDeEstacaoLista = new List<TipoEstacao>
        {
             new TipoEstacao("Estação Veicular"),
             new TipoEstacao("Estação Móvel")             
        };


        protected override bool EqualsCore(TipoEstacao other)
        {
            return Equals(other);
        }

        protected override int GetHashCodeCore()
        {
            return GetHashCode();
        }
    }
}
