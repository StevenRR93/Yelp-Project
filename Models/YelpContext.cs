using System;
using Microsoft.EntityFrameworkCore;
using Yelp.Controllers;
 
namespace Yelp.Models
{
    public class YelpContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public YelpContext(DbContextOptions<YelpContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
