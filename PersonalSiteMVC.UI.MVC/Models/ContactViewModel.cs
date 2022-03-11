using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSiteMVC.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="*Required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage ="*Required")]
        public string LastName { get; set; }


        [Required(ErrorMessage ="*Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage ="*Required")]
        public string Subject { get; set; }


        [Required(ErrorMessage ="*Required")]
        public string Message { get; set; }
    }
}