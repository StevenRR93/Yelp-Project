using System;
using System.ComponentModel.DataAnnotations;
namespace Yelp.Models
{
    public class Business
    {
        public int id {get; set; }
        public int RatingAverage { get; set; }
        public int NumberReviews { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}