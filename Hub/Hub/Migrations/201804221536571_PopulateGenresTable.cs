namespace Hub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO dbo.Genres (id, Name) VALUES (2, 'Rap')");
            Sql("INSERT INTO dbo.Genres (id, Name) VALUES (3, 'Pop')");
            Sql("INSERT INTO dbo.Genres (id, Name) VALUES (4, 'Rock')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Genres  WHERE id IN (1, 2, 3, 4)");
        }
    }
}
