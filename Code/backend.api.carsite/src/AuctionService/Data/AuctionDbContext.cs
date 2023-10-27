using Code.backend.api.carsite.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace Code.backend.api.carsite.src.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }
    
}