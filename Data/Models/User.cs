using System;
using System.ComponentModel.DataAnnotations;

namespace FlourishFitness.Pages
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLoggedIn { get; set; }
    }
}