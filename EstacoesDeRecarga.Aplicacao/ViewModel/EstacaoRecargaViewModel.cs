using EstacaoDeRecarga.Dominio.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstacaoDeRecarga.Aplicacao.ViewModel
{
   public class EstacaoRecargaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(300, ErrorMessage = "O Nome tem tamanho máximo de 300 caracteres.")]
        [MinLength(2, ErrorMessage = "O Nome tem tamanho mínimo de 2 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Tipo da Estação de Recarga")]                        
        [Required(ErrorMessage = "O campo Tipo da Estação é obrigatório.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O campo Latitude é obrigatório.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.#######}")]
        public decimal Latitude { get; set; }

        [Required(ErrorMessage = "O campo Longitude é obrigatório.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.#######}")]
        public decimal Longitude { get; set; }
    }
}
