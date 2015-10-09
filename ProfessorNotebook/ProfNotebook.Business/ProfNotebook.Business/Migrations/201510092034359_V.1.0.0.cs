namespace ProfNotebook.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V100 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proffesor",
                c => new
                    {
                        ProffesorID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Ape1 = c.String(maxLength: 50),
                        Ape2 = c.String(maxLength: 50),
                        DNI = c.String(maxLength: 9),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProffesorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proffesor");
        }
    }
}
