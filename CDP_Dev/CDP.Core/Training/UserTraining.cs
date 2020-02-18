using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Training
{
    public class UserTraining
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select User")]
        public int UserId { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "Select Training")]
        public int TrainingId { get; set; }
        public string Training { get; set; }
        public int PriorityId { get; set; }
        public string Priority { get; set; }
        public string TrainingCode { get; set; }
        public int TrainingCategoryId { get; set; }
        public string TrainingCategory { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
