namespace Core.Employee.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeTypeId { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
