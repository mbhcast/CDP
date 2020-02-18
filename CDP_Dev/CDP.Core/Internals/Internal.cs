using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Internals
{
    public class Internal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Topic")]
        public string Topic { get; set; }
        [Required(ErrorMessage = "Enter Training Mode")]
        public string TrainingMode { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
