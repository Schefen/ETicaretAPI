using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriterRepository _writerRepository;
        readonly private IProductReadRepository _readRepository;

        public ProductsController(IProductWriterRepository writerRepository, IProductReadRepository readRepository)
        {
            _writerRepository = writerRepository;
            _readRepository = readRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _writerRepository.AddRangeAsync(new()
            {
                new() {Id= Guid.NewGuid(),Name="Balta",Price=50,CreatedDate=DateTime.UtcNow,Stock=10},
                new() {Id= Guid.NewGuid(),Name="Kazma",Price=20,CreatedDate=DateTime.UtcNow,Stock=10},
                new() {Id= Guid.NewGuid(),Name="Kürek",Price=10,CreatedDate=DateTime.UtcNow,Stock=10},
                new() {Id= Guid.NewGuid(),Name="Kılıç",Price=40,CreatedDate=DateTime.UtcNow,Stock=10},
            });
            var count = await _writerRepository.SaveAsync();
        }
    }
}
