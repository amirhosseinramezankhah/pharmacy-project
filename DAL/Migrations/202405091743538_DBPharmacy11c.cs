namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBPharmacy11c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccessRoles", "CanAddInformation", c => c.Boolean(nullable: false));
            DropColumn("dbo.UserAccessRoles", "CanCreate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserAccessRoles", "CanCreate", c => c.Boolean(nullable: false));
            DropColumn("dbo.UserAccessRoles", "CanAddInformation");
        }
    }
}
