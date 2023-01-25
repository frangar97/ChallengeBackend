using Microsoft.AspNetCore.Mvc;
using Core.Shop.services;
using Core.Shop.DTO;
using Core.Shop;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService service;

        public ShopController(IShopService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetShops()
        {
            var shops = service.GetAll();
            var shopsDto = shops.Select(x => new ShopDTO { Id = x.Id, Name = x.Name, Address=x.Address,Telephone=x.Telephone }).ToList();
            return Ok(shopsDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShop([FromBody] CreateShopDTO data)
        {
            var shop = new ShopEntity { Name = data.Name, Address = data.Address, Telephone = data.Telephone };

            await service.CreateShop(shop);

            var shopDTO = new ShopDTO { Id = shop.Id, Name = shop.Name, Address = data.Address, Telephone = data.Telephone };

            return Ok(shopDTO);
        }
    }
}
