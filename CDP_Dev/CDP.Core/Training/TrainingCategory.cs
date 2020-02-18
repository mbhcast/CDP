using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Training
{
    public class TrainingCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Training Category Code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Enter Training Category Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Training Category Description")]
        public string Description { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
