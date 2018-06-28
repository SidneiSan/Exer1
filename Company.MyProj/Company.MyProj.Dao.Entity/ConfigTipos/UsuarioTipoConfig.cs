using Company.MyProj.Base.Entity;
using Company.MyProj.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.MyProj.Dao.Entity.ConfigTipos
{
    class UsuarioTipoConfig : CompanyMyProjEntityAbstrataConfig<Usuario>

    {
        protected override void CfgCamposTab()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Usr_ID");

            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("Usr_Nome")
                .HasMaxLength(100);

            Property(p => p.Login)
                   .IsRequired()
                   .HasColumnName("Usr_Login")
                   .HasMaxLength(100);

            Property(p => p.Status)
                   .IsRequired()
                   .HasColumnName("Usr_Status");
                   
       
        }

        protected override void CfgFKTab()
        {
            
        }

        protected override void CfgNomeTab()
        {
            ToTable("Tb_Usuarios");
        }

        protected override void CfgPKTab()
        {
            HasKey(pk => pk.Id);
        }
    }
}
