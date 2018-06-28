using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.MyProj.Base.Entity
{
    public abstract class CompanyMyProjEntityAbstrataConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public CompanyMyProjEntityAbstrataConfig()
        {
            CfgNomeTab();
            CfgCamposTab();
            CfgPKTab();
            CfgFKTab();

        }

        protected abstract void CfgFKTab();


        protected abstract void CfgPKTab();

        protected abstract void CfgCamposTab();

        protected abstract void CfgNomeTab();


        
    }
}
