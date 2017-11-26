using System;
using System.ComponentModel.DataAnnotations;
namespace Yelp.Models
{
    public class ReviewViewModel : BaseEntity
    {
        [Required]
        [Display(Name = "Item Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Item Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Starting Bid")]
        public int LastBid { get; set; }
        
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
    }
}