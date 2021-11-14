using System;
using System.ComponentModel.DataAnnotations;

namespace IotaOmicron.Framework.Data.Models.AppManagement
{
    public class Role
    {
        [Required(ErrorMessage = "Role ID is required")]
        public Guid RoleId { get; set; }
        public int RoleNumber { get; set; }
        [Required(ErrorMessage = "Role Code is required")]
        public string RoleCode { get; set; }
        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; }
        public bool IsCurrent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}