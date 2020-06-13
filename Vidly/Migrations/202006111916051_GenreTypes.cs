namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres  (Name,Id)  VALUES( 'Drama'1)");
            Sql("INSERT INTO Genres  (Name,Id)  VALUES( 'Comedy'2)");
            Sql("INSERT INTO Genres  (Name,Id)  VALUES('Action'3)");
            Sql("INSERT INTO Genres  (Name,Id)  VALUES('Family'4)");
            Sql("INSERT INTO Genres  (Name,Id)  VALUES('Adventure'5)");
        }
        
        public override void Down()
        {
        }
    }
}
