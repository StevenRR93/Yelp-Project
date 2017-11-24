using System;
using System.ComponentModel.DataAnnotations;
namespace Yelp.Models
{
    public class Review
    {
        public int id {get; set; }
        public int Rating { get; set; }
        public string ReviewDescription { get; set; }
        public int BusinessId { get; set; }
        public Business ReviewedBusiness { get; set; }
        public int UserId { get; set; }
        public User ReviewCreator { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}