using System;

namespace EstacaoDeRecarga.Dominio.Modelos
{
   public class EstacaoRecarga
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Tipo { get; set; }
                
        public decimal Latitude { get; set; }
                
        public decimal Longitude { get; set; }


    }
}
