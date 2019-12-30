namespace Lap04.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HandleDB : DbContext
    {
        public HandleDB()
            : base("name=Data")
        {
        }

        public virtual DbSet<Falculty> Falculty { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
