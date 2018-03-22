namespace HW15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHairColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "HairColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "HairColor");
        }
    }
}
