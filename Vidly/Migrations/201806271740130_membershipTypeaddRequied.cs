namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershipTypeaddRequied : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 255));
        }
    }
}
