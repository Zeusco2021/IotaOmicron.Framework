using System;
using System.ComponentModel.DataAnnotations;

namespace IotaOmicron.Framework.Data.Models.AppManagement
{
    public class Permission
    {
        [Required(ErrorMessage = "Permission ID is required")]
        public Guid PermissionId { get; set; }
        public int PermissionNumber { get; set; }
        [Required(ErrorMessage = "Permission Code is required")]
        public string PermissionCode { get; set; }
        [Required(ErrorMessage = "Permission Name is required")]
        public string PermissionName { get; set; }
        public bool IsCurrent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}