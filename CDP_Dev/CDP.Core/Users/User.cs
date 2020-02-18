using System;
using System.ComponentModel.DataAnnotations;

namespace CDP.Core.Users
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Display Name")]
        public string DisplayName { get; set; }
        [Required(ErrorMessage = "Enter Trigram")]
        public string Trigram { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        public int? ManagerId { get; set; }
        public string Manager { get; set; }
        public string ManagerTrigram { get; set; }
        public bool IsExternal { get; set; }
        public bool IsPresenter { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
