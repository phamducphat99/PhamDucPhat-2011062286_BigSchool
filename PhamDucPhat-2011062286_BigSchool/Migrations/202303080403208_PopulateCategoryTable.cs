namespace PhamDucPhat_2011062286_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, Name) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID, Name) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID, Name) VALUES (3, 'Marketing')");

        }
        public override void Down()
        {

        }
    }
}
