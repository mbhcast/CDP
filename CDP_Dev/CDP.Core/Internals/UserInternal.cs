using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Internals
{
    public class UserInternal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select User")]
        public int UserId { get; set; }
        public string User { get; set; }
        public int InternalId { get; set; }
        public string Topic { get; set; }
        public string TrainingMode { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
