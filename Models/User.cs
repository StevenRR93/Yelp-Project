using System;
using System.ComponentModel.DataAnnotations;
namespace Yelp.Models
{
    public class User
    {
        public int id {get; set; }
        public int ReviewCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string PersonalDescription { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}