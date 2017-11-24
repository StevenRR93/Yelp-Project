using System;
using Microsoft.EntityFrameworkCore;
using Auction_exam.Controllers;
 
namespace Auction_exam.Models
{
    public class AuctionContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public AuctionContext(DbContextOptions<AuctionContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
    }
}
