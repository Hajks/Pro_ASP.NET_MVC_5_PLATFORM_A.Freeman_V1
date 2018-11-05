using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i naziwsko.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określić, czy weźmiesz udział.")]
        public bool? WillAtend { get; set; }
    }
}