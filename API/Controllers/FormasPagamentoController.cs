using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FormasPagamentoController
    {
        [ApiController]
        [Route("api/pagamento")]

        public class ProdutoController : ControllerBase
        {
            private const string V = "create";
            private readonly DataContext _context;

            public ProdutoController(DataContext context) => _context = context;


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