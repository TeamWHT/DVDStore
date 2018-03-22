using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Online.DataBase.Models
{
    class DBContext:DbContext
    {
        public DbSet<DVD> DVDS { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DBContext() : base("DVD-Store-DataBase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Migrations.Configuration>());
        }
    }

    

}
