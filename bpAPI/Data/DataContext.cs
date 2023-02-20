using Microsoft.EntityFrameworkCore;

namespace bpAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Nome da tabela
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
