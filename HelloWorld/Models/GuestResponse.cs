using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")] // validate name entry
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]// validate phone entry
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]//validate email entry
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter if you will attend")]// validate will attend entry
        public bool? WillAttend { get; set; }
    }



}