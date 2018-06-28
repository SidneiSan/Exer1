using AutoMapper;
using Company.MyProj.Dominio;
using Company.MyProj.Web.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.MyProj.Web.AutoMapper
{
    public class DominioToViewModel : Profile
    {

        public class AutoMapperConfig
        {

            public static void RegisterMappings()

            {
                Mapper.Initialize(x =>

                {
                    x.CreateMap<Usuario, UsuarioIndexViewModel>();
                    x.CreateMap<Usuario, ViewModeltoDominio>();
                    x.AddProfile<DominioToViewModel>();

                });

            }

        }




    }
}