using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_MongoCRUD.Models;
using WebAPI_MongoCRUD.Services;

namespace WebAPI_MongoCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoServices _produtoService;

        public ProdutoController(ProdutoServices produtoServices)
        {
            _produtoService = produtoServices;
        }

        [HttpGet]
        public async Task<List<Produto>> GetProdutos()
            => await _produtoService.GetAsync();

        [HttpPost]
        public async Task<Produto> PostProduto(Produto produto)
        {
            await _produtoService.CreateAsync(produto);
            return produto;
        }
        

    }
}
