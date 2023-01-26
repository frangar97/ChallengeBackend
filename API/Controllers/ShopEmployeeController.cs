using Core.ShopEmployee;
using Core.ShopEmployee.DTO;
using Core.ShopEmployee.services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopEmployeeController : ControllerBase
    {
        private readonly IShopEmployeeService service;

        public ShopEmployeeController(IShopEmployeeService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateShopEmployee([FromBody] CreateShopEmployeeDTO data)
        {
            var shopEmployee = new ShopEmployeeEntity { EmployeeId= data.EmployeeId ,ShopId=data.ShopId,WorkDate=data.WorkDate};
            await service.CreateShopEmployee(shopEmployee);
            return Ok();
        }
    }
}
