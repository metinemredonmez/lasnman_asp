using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using lansman.Configuration;
using lansman.Web;

namespace lansman.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class lansmanDbContextFactory : IDesignTimeDbContextFactory<lansmanDbContext>
    {
        public lansmanDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<lansmanDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            lansmanDbContextConfigurer.Configure(builder, configuration.GetConnectionString(lansmanConsts.ConnectionStringName));

            return new lansmanDbContext(builder.Options);
        }
    }
}
