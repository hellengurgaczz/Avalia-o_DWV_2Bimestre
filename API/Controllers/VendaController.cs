using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendaController : ControllerBase
    {
        private readonly DataContext _context;
        public VendaController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("criarvenda")]
        public IActionResult CriarVenda([FromBody] Venda venda)
        {
            venda.ItemVenda = _context.ItensVenda.Find(venda.ItemVendaId);
            venda.FormaPagamento = _context.FormasPagamento.Find(venda.FormaId);
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return Created("", venda);
        }

        //GET: api/venda/list
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            return Ok(_context.Vendas
            .Include(Pagamento => Pagamento.FormaPagamento)
            .ToList());
        }
    }
}