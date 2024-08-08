using Microsoft.EntityFrameworkCore;
using misa_intern_back.Models;

namespace misa_intern_back.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    
}