using AutoMapper;
using Company.MyProj.Dominio;
using Company.MyProj.Web.AutoMapper;
using Company.MyProj.Web.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.MyProj.Web.App_Start
{
    public static class AutoMapperConfig
    {

        public static IMapper Mapper { get; private set; }
        public static void ConfiguraMapps()
        
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Usuario, UsuarioIndexViewModel>();
                cfg.AddProfile<DominioToViewModel>();

                cfg.CreateMap<ViewModeltoUsuario, Usuario>();
                cfg.AddProfile<ViewModeltoDominio>();
            });

            Mapper = config.CreateMapper();

        }
    }
}