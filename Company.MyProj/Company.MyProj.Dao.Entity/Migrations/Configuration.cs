namespace Company.MyProj.Dao.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Company.MyProj.Dao.Entity.Context.MyProjDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Company.MyProj.Dao.Entity.Context.MyProjDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.Usuarios.AddOrUpdate(
            //    p => p.Login,
            //    new  Dominio.Usuario { })

        }
    }
}
