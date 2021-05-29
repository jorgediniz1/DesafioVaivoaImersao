using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioVaiVoa.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa  { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(254, ErrorMessage = "Este campo deve conter no máximo 254 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo deve conter no mínimo 10 caracteres")] 
        public string Email { get; set; }
        public ICollection<Card> ListCards { get; set; } = new List<Card>();


        public void AddCard(Card card)
        {
            ListCards.Add(card);
        }
        
    }
}
