using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Allocations
{
    public class UserAllocation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select User")]
        public int UserId { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "Select Allocation")]
        public int AllocationId { get; set; }
        public string Allocation { get; set; }
        public string Comment { get; set; }
        public int PriorityId { get; set; }
        public string Priority { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
