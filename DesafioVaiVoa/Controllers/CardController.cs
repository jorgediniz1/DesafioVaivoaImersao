using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DesafioVaiVoa.Data;
using DesafioVaiVoa.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesafioVaiVoa.Controllers
{
    [ApiController]
    [Route("v1/cards")]
    public class CardController : ControllerBase
    {
        public readonly DataContext _context;

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Card>> Post(
          [FromServices] DataContext context,
          [FromBody] Card model)   

        {
            if (ModelState.IsValid)
            {
                string numCard = "";
                Card card = new Card();
                //Simulando a entrada do parâmentro email. 
                Pessoa pessoa1 = new Pessoa();
                pessoa1.Email = "onediniz2 @gmail.com";
                int optFlag = 1;
                //Simulando a entrada do parâmetro opção optFlag = 1 , que é o cartão Visa.
                numCard = card.NewNumber(optFlag);
                card.Number = numCard;
                if(optFlag == 1)
                {
                    card.Flag = "Visa";
                }
                card.Email = pessoa1.Email;
                card.Pessoa = pessoa1;
                pessoa1.AddCard(card);

                context.Cards.Add(model);
                await context.SaveChangesAsync();
                return model;  
            }
            else
            {
                return BadRequest();
            }

            

/*
            [HttpGet]
            [Route("")]
            public async Task<ActionResult<List<Card>>> Get([FromServices] DataContext context)
            {
                var pessoa = await context.Pessoas.Include (x => x.ListCards).ToListAsync();
                return pessoa;
            }
*/
        }
    }
}
