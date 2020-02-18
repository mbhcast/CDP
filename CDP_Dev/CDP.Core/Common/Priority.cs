using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Common
{
    public class Priority
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Topic")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Training Mode")]
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
