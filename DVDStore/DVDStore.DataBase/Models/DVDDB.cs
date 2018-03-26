using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace DVDStore.DataBase.Models
{
    public class DVDDB: DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<DVD> DVDs { get; set; }

        public DVDDB() : base("DVDStoreDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DVDDB, Migrations.Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor>()
                .HasMany(t => t.DVD_Title)
                .WithMany(t => t.Actor_Name)
                .Map(m => 
                {
                    m.ToTable("DVDActors");
                    m.MapLeftKey("Actor_ID");
                    m.MapRightKey("DVD_ID");
                });
            base.OnModelCreating(modelBuilder);
        }
        

    }
}
