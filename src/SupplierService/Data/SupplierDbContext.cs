using Microsoft.EntityFrameworkCore;

namespace SupplierService.Data;

public class SupplierDbContext : DbContext
{
    public SupplierDbContext(DbContextOptions options) : base(options)
    {
    }

}
