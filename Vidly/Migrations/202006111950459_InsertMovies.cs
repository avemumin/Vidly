namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES( Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) values('Batman',1,'20100401','20110101',3,6)");
            Sql("INSERT INTO MOVIES( Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) values('Superman',2,'20110401','20120101',6,11)");
            Sql("INSERT INTO MOVIES( Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) values('Klan',3,'20000311','20110101',18,1)");
            Sql("INSERT INTO MOVIES( Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) values(" +
                "'Barwy nieszczescia',4,'20110401','20160101',11,4)");
            Sql("INSERT INTO MOVIES( Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) values" +
                "('4 pancerni i sabaka',5,'20000311','20110101',18,1)");
        }

      
        public override void Down()
        {
        }
    }
}
