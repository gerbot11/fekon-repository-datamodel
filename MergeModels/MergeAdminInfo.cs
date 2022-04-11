using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeAdminInfo
    {
        public AspNetUser AspNetUser { get; set; }
        public string UserRole { get; set; }
        public IEnumerable<ActivityDetail> UserActivityDetail { get; set; }
        public RefEmployee RefEmployee { get; set; }
        public int TotalRepositorySubmit { get; set; }
        public PasswordChangeInputModel PasswordChangeInputModel { get; set; }
    }

    public class ActivityDetail
    {
        public DateTime DateActivity { get; set; }
        public IEnumerable<UserActivityHist> UserActivityHists { get; set; }
    }

    public class PasswordChangeInputModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
