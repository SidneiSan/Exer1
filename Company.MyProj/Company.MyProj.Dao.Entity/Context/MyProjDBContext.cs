using Company.MyProj.Dao.Entity.ConfigTipos;
using Company.MyProj.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.MyProj.Dao.Entity.Context
{
    public class MyProjDBContext: DbContext
    {
        public  DbSet<Usuario> Usuarios { get; set; }

        public MyProjDBContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioTipoConfig());

        }

    }
}
