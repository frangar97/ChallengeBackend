using Core.EmployeeType;
using Core.EmployeeType.DTO;
using Core.EmployeeType.services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTypeController : ControllerBase
    {
        private readonly IEmployeeTypeService service;

        public EmployeeTypeController(IEmployeeTypeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetEmployeeTypes()
        {
            var employeeTypes = service.GetAll();
            var employeeTypesDto = employeeTypes.Select(x=>new EmployeeTypeDTO { Id=x.Id,Name=x.Name,Salary=x.Salary}).ToList();
            return Ok(employeeTypesDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployeeType([FromBody] CreateEmployeeTypeDTO data)
        {
            var employeeType = new EmployeeTypeEntity { Name=data.Name,Salary=data.Salary };

            await service.CreateEmployeeType(employeeType);

            var employeeTypeDto = new EmployeeTypeDTO { Id = employeeType.Id, Name = employeeType.Name, Salary = employeeType.Salary };

            return Ok(employeeTypeDto);
        }
    }
}
