using Microsoft.AspNetCore.Mvc;
using Core.Employee.services;
using Core.Employee.DTO;
using Core.Employee;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = service.GetAll();
            var employeesDTO = employees.Select(x => new EmployeeDTO { Id = x.Id, Name = x.Name,Address=x.Address,Telephone=x.Telephone,EmployeeTypeId=x.EmployeeTypeId,EmploymentDate=x.EmploymentDate }).ToList();
            return Ok(employeesDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDTO data)
        {
            var employee = new EmployeeEntity { Name = data.Name, Address = data.Address, EmployeeTypeId=data.EmployeeTypeId,EmploymentDate=data.EmploymentDate,Telephone=data.Telephone };

            await service.CreateEmployee(employee);

            var employeeTypeDto = new EmployeeDTO { Id = employee.Id, Name = employee.Name, Address = employee.Address, EmployeeTypeId = employee.EmployeeTypeId, EmploymentDate = employee.EmploymentDate, Telephone = employee.Telephone };

            return Ok(employeeTypeDto);
        }
    }
}
