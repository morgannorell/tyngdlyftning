namespace tyngdlyftning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 255),
                        TAddress = c.String(maxLength: 1024),
                        TPnr = c.String(maxLength: 25),
                        TCity = c.String(maxLength: 50),
                        TPhone = c.String(maxLength: 25),
                        TEmail = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Team");
        }
    }
}
