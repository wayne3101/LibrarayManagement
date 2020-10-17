namespace LibraryManegement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pupils", "Pupils_first_name", c => c.String());
            AddColumn("dbo.Pupils", "Pupils_middle_name", c => c.String());
            AddColumn("dbo.Pupils", "Pupils_last_name", c => c.String());
            DropColumn("dbo.Pupils", "Author_first_name");
            DropColumn("dbo.Pupils", "Author_middle_name");
            DropColumn("dbo.Pupils", "Author_last_name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pupils", "Author_last_name", c => c.String());
            AddColumn("dbo.Pupils", "Author_middle_name", c => c.String());
            AddColumn("dbo.Pupils", "Author_first_name", c => c.String());
            DropColumn("dbo.Pupils", "Pupils_last_name");
            DropColumn("dbo.Pupils", "Pupils_middle_name");
            DropColumn("dbo.Pupils", "Pupils_first_name");
        }
    }
}
