using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetWebApp.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; }

        [DisplayName("Image Uri")]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        [DisplayName("Date Created")]
        public string DateCreated { get; set; } = DateTime.Now.ToString("MMMM d, yyyy").ToUpper();
    }
}