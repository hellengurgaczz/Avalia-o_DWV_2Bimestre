using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializarDados")]
    public class IniciarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public IniciarDadosController(DataContext context) => _context = context;

        // POST: api/inicializarDados/create
        [HttpPost]
        [Route("create")]

        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { Id = 1, Nome = "Tecnologia" },
                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "IPad", Preco = 2.500, Quantidade = 4, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Notbook Dell", Preco = 3.650, Quantidade = 1, CategoriaId = 1 },
                    new Produto { ProdutoId = 3, Nome = "Tabelt Samsung", Preco = 1.700, Quantidade = 10, CategoriaId = 1 },
                    new Produto { ProdutoId = 4, Nome = "Fone JBL", Preco = 650.00, Quantidade = 25, CategoriaId = 1 },
                }
            );

            _context.SaveChanges();
            return Ok(new { message = "Parabéns! Dados inicializados!" });
        }
    }
}