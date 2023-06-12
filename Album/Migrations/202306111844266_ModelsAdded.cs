namespace Album.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Name");
        }
    }
}
