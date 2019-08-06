namespace Grafik_Ornek.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GrafikDBContext : DbContext
    {
        public GrafikDBContext()
            : base("name=GrafikDBContext")
        {
        }

        public virtual DbSet<tblAylikGiraf> tblAylikGirafs { get; set; }
        public virtual DbSet<tblHaftalikGraf> tblHaftalikGrafs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAylikGiraf>()
                .Property(e => e.Tarih)
                .IsUnicode(false);

            modelBuilder.Entity<tblHaftalikGraf>()
                .Property(e => e.gun)
                .IsUnicode(false);
        }
    }
}
