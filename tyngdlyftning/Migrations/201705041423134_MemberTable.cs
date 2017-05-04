namespace tyngdlyftning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        LiftId = c.String(nullable: false, maxLength: 10),
                        Address = c.String(maxLength: 100),
                        Pnr = c.String(maxLength: 100),
                        City = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 25),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Member");
        }
    }
}
