namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUPFee, DurationInMonths, DiscountRate) Values (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUPFee, DurationInMonths, DiscountRate) Values (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUPFee, DurationInMonths, DiscountRate) Values (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUPFee, DurationInMonths, DiscountRate) Values (4, 300, 3, 40)");
        }
        
        public override void Down()
        {
        }
    }
}
