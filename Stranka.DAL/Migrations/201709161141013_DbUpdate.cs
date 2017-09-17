namespace Stranka.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Ime", c => c.String());
            AddColumn("dbo.AspNetUsers", "Prezime", c => c.String());
            AddColumn("dbo.AspNetUsers", "JMBG", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "JMBG");
            DropColumn("dbo.AspNetUsers", "Prezime");
            DropColumn("dbo.AspNetUsers", "Ime");
        }
    }
}
