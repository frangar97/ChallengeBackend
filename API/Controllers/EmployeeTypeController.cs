using Core.Base;
using Core.EmployeeType;
using Core.EmployeeType.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTypeController : ControllerBase
    {
        private readonly IRepository<EmployeeTypeEntity> _repository;

        public EmployeeTypeController(IRepository<EmployeeTypeEntity> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetEmployeeTypes()
        {
            var employeeTypes = _repository.GetAll();
            var employeeTypesDto = employeeTypes.Select(x=>new EmployeeTypeDTO { Id=x.Id,Name=x.Name,Salary=x.Salary}).ToList();
            return Ok(employeeTypesDto);
        }
    }
}
