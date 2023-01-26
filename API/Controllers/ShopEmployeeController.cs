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

        [HttpGet]
        public async Task<IActionResult> GetShopEmployees()
        {
            var shopEmployees = await service.GetAll();
            var shopEmployeesDTO = shopEmployees.Select(x => new ShopEmployeeDTO{ Id=x.Id,ShopName=x.Shop.Name,EmployeeName=x.Employee.Name,WorkDate=x.WorkDate }).ToList();
            return Ok(shopEmployeesDTO);
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
