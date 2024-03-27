using Microsoft.EntityFrameworkCore;
using Miriam.Infrastructure.Authentication;

namespace Miriam.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<AuthenticationUser> Users { get; set; }
}