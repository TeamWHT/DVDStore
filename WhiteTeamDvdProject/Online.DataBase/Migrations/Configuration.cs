namespace Online.DataBase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    internal sealed class Configuration : DbMigrationsConfiguration<Online.DataBase.Models.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Online.DataBase.Models.DBContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
            context.DVDS.AddOrUpdate(x => x.ID,
                new DVD()
                {
                    Title = "John Wick",
                    Genre = "Action",
                    TimeLength = "1h 41min",
                    Language = "English",
                    Rating = "R",
                    Sold = 3,
                    Price = "$9.96",
                },
                new DVD()
                {
                    Title = "Rush Hour",
                    Genre = "Action",
                    TimeLength = "1h 38min",
                    Language = "English",
                    Rating = "PG-13",
                    Sold = 4,
                    Price = "$7.50",
                },
                new DVD()
                {
                    Title = "Braveheart",
                    Genre = "Action",
                    TimeLength = "3h 2min",
                    Language = "English",
                    Rating = "R",
                    Sold = 2,
                    Price = "$2.99",
                },
                new DVD()
                {
                    Title = "Alexander",
                    Genre = "Action",
                    TimeLength = "3h 34min",
                    Language = "English",
                    Rating = "R",
                    Sold = 3,
                    Price = "$10.50",
                },
                new DVD()
                {
                    Title = "The Foreigner",
                    Genre = "Mystery",
                    TimeLength = "1h 56m",
                    Language = "English",
                    Rating = "R",
                    Sold = 3,
                    Price = "$12.99",
                }
                );

            context.Actors.AddOrUpdate(x => x.ID




            );

        }
    }
}
