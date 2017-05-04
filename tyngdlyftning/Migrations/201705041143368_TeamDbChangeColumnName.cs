namespace tyngdlyftning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamDbChangeColumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Team", "Address", c => c.String(maxLength: 1024));
            AddColumn("dbo.Team", "Pnr", c => c.String(maxLength: 25));
            AddColumn("dbo.Team", "City", c => c.String(maxLength: 50));
            AddColumn("dbo.Team", "Phone", c => c.String(maxLength: 25));
            AddColumn("dbo.Team", "Email", c => c.String(maxLength: 50));
            DropColumn("dbo.Team", "TAddress");
            DropColumn("dbo.Team", "TPnr");
            DropColumn("dbo.Team", "TCity");
            DropColumn("dbo.Team", "TPhone");
            DropColumn("dbo.Team", "TEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Team", "TEmail", c => c.String(maxLength: 50));
            AddColumn("dbo.Team", "TPhone", c => c.String(maxLength: 25));
            AddColumn("dbo.Team", "TCity", c => c.String(maxLength: 50));
            AddColumn("dbo.Team", "TPnr", c => c.String(maxLength: 25));
            AddColumn("dbo.Team", "TAddress", c => c.String(maxLength: 1024));
            DropColumn("dbo.Team", "Email");
            DropColumn("dbo.Team", "Phone");
            DropColumn("dbo.Team", "City");
            DropColumn("dbo.Team", "Pnr");
            DropColumn("dbo.Team", "Address");
        }
    }
}
