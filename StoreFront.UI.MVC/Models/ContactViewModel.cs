using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Added for Validation
using System.Linq;
using System.Web;

namespace StoreFront.UI.MVC.Models
{
    public class ContactViewModel
    {
        //Props

        [Required(ErrorMessage = "This is a required field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [EmailAddress(ErrorMessage = "Please use a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [UIHint("MultilineText")]
        public string Body { get; set; }

    }
}