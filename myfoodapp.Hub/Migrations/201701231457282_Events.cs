namespace myfoodapp.Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Events : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Events");
            AlterColumn("dbo.Events", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Events", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Events");
            AlterColumn("dbo.Events", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Events", "Id");
        }
    }
}
