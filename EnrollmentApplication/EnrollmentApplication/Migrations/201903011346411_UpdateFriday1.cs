namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFriday1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Address1", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Address2", c => c.String(nullable: false));
            AddColumn("dbo.Students", "City", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Zipcode", c => c.String(nullable: false));
            AddColumn("dbo.Students", "State", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "State");
            DropColumn("dbo.Students", "Zipcode");
            DropColumn("dbo.Students", "City");
            DropColumn("dbo.Students", "Address2");
            DropColumn("dbo.Students", "Address1");
        }
    }
}
