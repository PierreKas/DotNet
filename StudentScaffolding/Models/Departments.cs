using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentScaffolding.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  HoDName { get; set; }
        public ICollection<Student> Students { get; set; }


    }
}