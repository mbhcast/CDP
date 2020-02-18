using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Allocations
{
    public class Allocation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
