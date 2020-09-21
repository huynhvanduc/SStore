using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Name { set; get; }
        [Required]
        public string Password { set; get; }
        public string ReturnUrl { set; get; } = "/";
    }
}
