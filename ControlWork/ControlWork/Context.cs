namespace ControlWork
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {     
        public Context()
            : base("DbConnection=Model1")
        {
        }
        public DbSet<News> News { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Comments> Comment { get; set; }

    }

    
}