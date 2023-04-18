using Microsoft.EntityFrameworkCore;
using UserCrudApi.Domain.Model;

namespace UserCrudApi.Domain;

public class UserCrudContext : DbContext
{
    public DbSet <User> Users{ get; set; }
    public UserCrudContext(DbContextOptions options) : base(options)
    {

    }
}
