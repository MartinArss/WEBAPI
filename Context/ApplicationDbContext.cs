using Microsoft.EntityFrameworkCore;
using SegundaApiCRUD.Entities;

namespace SegundaApiCRUD.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Articulo> ArticuloDb { get; set; }
    }
}
