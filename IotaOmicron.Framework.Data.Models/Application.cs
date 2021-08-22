using System;
using System.ComponentModel.DataAnnotations;

namespace IotaOmicron.Framework.Data.Models
{
    public class Application
    {
        [Required(ErrorMessage = "Application ID is required")]
        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public bool IsCurrent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModificationDate { get; set; }
    }
}
