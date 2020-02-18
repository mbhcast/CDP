using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDP.Core.Skills
{
    public class UserSkill
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select User")]
        public int UserId { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "Select Skill")]
        public int SkillId { get; set; }
        public string Skill { get; set; }
        public int SkillTypeId { get; set; }
        public string SkillType { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
