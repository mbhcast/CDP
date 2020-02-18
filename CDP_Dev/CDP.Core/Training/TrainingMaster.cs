using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Training
{
    public class TrainingMaster
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Training Code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Enter Training Name")]
        public string Name { get; set; }

        public int TrainingCategoryId { get; set; }

        [Required(ErrorMessage = "Enter Training Category")]
        public string TrainingCategory { get; set; }

        [Required(ErrorMessage = "Enter Training Description")]
        public string Description { get; set; }
        public string TOC { get; set; }
        public bool IsExternal { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
