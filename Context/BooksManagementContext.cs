using System.Data.Entity;
using WebApplicationCoreWebApi.Models;

namespace Context
{
    public partial class BooksManagementContext : DbContext
    {
        static string connectionString = "Data Source=" + @"localhost\SQLEXPRESS01" + ";Initial Catalog=BooksManagementDB;Integrated Security=True;User ID=" + @"Inspop\meenakshi.sangotra";
        public BooksManagementContext() : base(connectionString)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
