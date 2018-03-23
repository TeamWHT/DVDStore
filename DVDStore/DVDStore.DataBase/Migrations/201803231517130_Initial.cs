namespace DVDStore.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DVDs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        TimeLength = c.String(),
                        Language = c.String(),
                        Rating = c.String(),
                        Sold = c.Int(nullable: false),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DVDActors",
                c => new
                    {
                        Actor_ID = c.Int(nullable: false),
                        DVD_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Actor_ID, t.DVD_ID })
                .ForeignKey("dbo.Actors", t => t.Actor_ID, cascadeDelete: true)
                .ForeignKey("dbo.DVDs", t => t.DVD_ID, cascadeDelete: true)
                .Index(t => t.Actor_ID)
                .Index(t => t.DVD_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DVDActors", "DVD_ID", "dbo.DVDs");
            DropForeignKey("dbo.DVDActors", "Actor_ID", "dbo.Actors");
            DropIndex("dbo.DVDActors", new[] { "DVD_ID" });
            DropIndex("dbo.DVDActors", new[] { "Actor_ID" });
            DropTable("dbo.DVDActors");
            DropTable("dbo.DVDs");
            DropTable("dbo.Actors");
        }
    }
}
