using System.Data.Entity;

namespace vs1.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<blog> blogs { get; set; }
        public DbSet<yorumlar> yorumlars { get; set; }
        public DbSet<driverstanding> driverstandings { get; set; }
        public DbSet<constructorstanding> constructorstandings { get; set; }
        public DbSet<test> tests { get; set; }
    }
}