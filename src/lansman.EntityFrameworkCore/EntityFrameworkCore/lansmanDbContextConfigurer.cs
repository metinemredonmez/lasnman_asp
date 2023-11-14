using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace lansman.EntityFrameworkCore
{
    public static class lansmanDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<lansmanDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<lansmanDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
