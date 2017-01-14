using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetWebApp.Models
{
    public class ContactEmail
    {
        [Required]
        [Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required]
        [Display(Name = "Your email")]
        [EmailAddress]
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}