using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVaiVoa.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Flag { get; set; }
        public Pessoa Pessoa { get; set; }

        public Card()
        {
        }

        public Card(int id, string email, string number, string flag, Pessoa pessoa)
        {
            Id = id;
            Email = email;
            Number = number;
            Flag = flag;
            Pessoa = pessoa;
        }

        private readonly int[] Visa = { 4 };
        public readonly string[] Flags = {"Visa"};
        
        //SELECIONE A BANDEIRA DO CARTÃO:
        //1 - VISA
        public string NewNumber(int optFlag)
        {
            Random a = new Random();
            string numberCard = "";

            //Captura o número inicial do numero do cartão, identificando a bandeira. 
            if (optFlag == 1)
            {
                numberCard = Visa[a.Next(Visa.Length)].ToString();
            }
            else
            {
                Console.WriteLine("Invalid option, select valid option!!");
            }
                 

            while(numberCard.Length < 16) //Cria os 16 numeros que possuem um cartão de crédito
            {
                numberCard += a.Next(10);
            }
            return numberCard;
        }








    }
}
