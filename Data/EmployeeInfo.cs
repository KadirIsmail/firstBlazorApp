using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstBlazorApp.Data
{
    public class EmployeeInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
    }
}
