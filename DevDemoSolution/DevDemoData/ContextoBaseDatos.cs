using DevDemoEntities;
using Microsoft.EntityFrameworkCore;

namespace DevDemoData
{
    public class ContextoBaseDatos : DbContext
    {
        public ContextoBaseDatos(DbContextOptions<ContextoBaseDatos> options) : base(options)
        {
        }

        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<RequestStatusLog> RequestStatusLogs { get; set; }
        public DbSet<TotalBudget> TotalBudgets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionsHistory> TransactionsHistories { get; set; }
    }
}
