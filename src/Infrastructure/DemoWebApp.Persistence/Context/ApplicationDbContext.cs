using Microsoft.EntityFrameworkCore;
using DemoWebApp.Domain.Entities;

namespace DemoWebApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        #region Ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        #endregion

        #region Db Set
        DbSet<t_AlertEvents> t_AlertEvents { get; set; }
        #endregion

    }
}
