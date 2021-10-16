using System;
using System.ComponentModel.DataAnnotations;

namespace IotaOmicron.Framework.Data.Models.AppManagement
{
    public class Application
    {
        [Required(ErrorMessage = "Application ID is required")]
        public Guid ApplicationId { get; set; }

        public int ApplicationNumber { get; set; }
        [Required(ErrorMessage = "Application Code is required")]
        public string ApplicationCode { get; set; }
        [Required(ErrorMessage = "Application Name is required")]
        public string ApplicationName { get; set; }
        public bool IsCurrent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
