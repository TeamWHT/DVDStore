namespace HW15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Extrapoints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "ExtraPoints", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "ExtraPoints");
        }
    }
}
