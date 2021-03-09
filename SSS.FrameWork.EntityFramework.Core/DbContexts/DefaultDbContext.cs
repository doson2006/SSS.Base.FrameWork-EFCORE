using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SSS.FrameWork.Core;

namespace SSS.FrameWork.EntityFramework.Core
{
    [AppDbContext("OracleConnectionString", DbProvider.Oracle)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}