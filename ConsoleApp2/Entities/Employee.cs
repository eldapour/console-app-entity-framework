using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console_Application.Entities
{
    class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department department { get; set; }
    }
}
