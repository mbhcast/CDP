using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Aspirations
{
    public class UserAspiration
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select User")]
        public int UserId { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "Type Description")]
        [MaxLength(5000)]
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
