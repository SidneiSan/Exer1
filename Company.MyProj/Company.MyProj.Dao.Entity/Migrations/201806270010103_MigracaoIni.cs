namespace Company.MyProj.Dao.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoIni : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_Usuarios",
                c => new
                    {
                        Usr_ID = c.Int(nullable: false, identity: true),
                        Usr_Login = c.String(nullable: false, maxLength: 100),
                        Usr_Nome = c.String(nullable: false, maxLength: 100),
                        Usr_Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Usr_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tb_Usuarios");
        }
    }
}
