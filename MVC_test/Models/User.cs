using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_test.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Wymagane pole imię.")]
        public string Login { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }
        [Required(ErrorMessage = "Wymagane hasło.")]
        public string Password { get; set; }
        public DateTime? Birth_date { get; set; }
        public byte[] Photo { get; set; }

        public ICollection<Basket> Basket;
    }
}