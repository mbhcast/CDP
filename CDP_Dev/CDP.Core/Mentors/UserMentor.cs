using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Mentors
{
    public class UserMentor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select User")]
        public int UserId { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "Select Mentor")]
        public int MentorId { get; set; }
        public string Mentor { get; set; }
        [Required(ErrorMessage = "Select Training Category")]
        public int TrainingCategoryId { get; set; }
        public string TrainingCategory { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
