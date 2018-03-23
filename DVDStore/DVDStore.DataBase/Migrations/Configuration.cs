namespace DVDStore.DataBase.Migrations
{
    using DVDStore.DataBase.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DVDStore.DataBase.Models.DVDDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DVDStore.DataBase.Models.DVDDB context) =>
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.DVDs.AddOrUpdate(x => x.ID,
                new DVD
                {
                   Title="John Wick",
                   Genre="Action",
                   Language="En",
                   Rating="R",
                   Price="$9.75",
                   Sold=3,
                   TimeLength="1h 41min",
                   
                },
                new DVD
                {
                    Title = "Rush Hour",
                    Genre = "Action",
                    Language = "En",
                    Rating = "PG-13",
                    Price = "$7.99",
                    Sold =4,
                    TimeLength = "1h 38min",

                },
                new DVD
                {
                    Title = "Braveheart",
                    Genre = "Action",
                    Language = "En",
                    Rating = "R",
                    Price = "$10.50",
                    Sold =2,
                    TimeLength = "3h 2min",

                },
                new DVD
                {
                    Title = "Alexander",
                    Genre = "Action",
                    Language = "En",
                    Rating = "R",
                    Price = "$12.99",
                    Sold =3,
                    TimeLength = "3h 34min",

                },
                new DVD
                {
                    Title = "The Foreigner",
                    Genre = "Mystery ",
                    Language = "En",
                    Rating = "R",
                    Price = "$15.35",
                    Sold =2,
                    TimeLength = "1h 56min",

                }
            );
                
        }
    }
}
