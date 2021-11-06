using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Authorization.Models
{
    public class AppIdentityContext : IdentityDbContext<User>
    {
        public AppIdentityContext(DbContextOptions<AppIdentityContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
