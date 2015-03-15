using System.ComponentModel.DataAnnotations;

namespace A3_EF6_Ext.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
        public string Designation { get; set; }
    }
}
