namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Genres (Id,Name) Values (1,'Drama')");
            Sql("Insert INTO Genres (Id,Name) Values (2,'Comedy')");
            Sql("Insert INTO Genres (Id,Name) Values (3,'Action')");
            Sql("Insert INTO Genres (Id,Name) Values (4,'Family')");
            Sql("Insert INTO Genres (Id,Name) Values (5,'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
