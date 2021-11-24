using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pagamento")]
    public class FormasPagamentoController
    {

        public class Form : ControllerBase
        {
            private readonly DataContext _context;

            public FormasPagamentoController(DataContext context) => _context = context;


            //POST: api/pagamento/create
            [HttpPost]
            [Route("create")]
            public IActionResult Create([FromBody] FormaPagamento FormaPagamento)
            {
                _context.FormasPagamento.Add(FormaPagamento);
                _context.SaveChanges();
                return Created("", FormaPagamento);
            }

        }
    }
}