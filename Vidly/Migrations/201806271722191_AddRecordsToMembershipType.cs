namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecordsToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay as You Go' Where id = 1 ");
            Sql("UPDATE MembershipTypes SET Name='Monthly' Where id = 2 ");
            Sql("UPDATE MembershipTypes SET Name='Quarterly' Where id = 3 ");
            Sql("UPDATE MembershipTypes SET Name='Yearly' Where id = 4 ");

        }
        
        public override void Down()
        {
        }
    }
}
