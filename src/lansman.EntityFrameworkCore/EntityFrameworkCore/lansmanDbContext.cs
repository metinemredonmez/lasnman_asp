using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using lansman.Authorization.Roles;
using lansman.Authorization.Users;
using lansman.MultiTenancy;

namespace lansman.EntityFrameworkCore
{
    public class lansmanDbContext : AbpZeroDbContext<Tenant, Role, User, lansmanDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public lansmanDbContext(DbContextOptions<lansmanDbContext> options)
            : base(options)
        {
        }
    }
}
