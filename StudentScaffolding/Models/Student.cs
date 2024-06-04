using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentScaffolding.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int departmentId { get; set; }
        [ForeignKey("departmentId")]
        public Departments department { get; set;}
        
    }
}