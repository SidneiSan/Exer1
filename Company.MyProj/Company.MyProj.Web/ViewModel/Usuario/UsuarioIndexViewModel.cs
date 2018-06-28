using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Company.MyProj.Web.ViewModel.Usuario
{
    public class UsuarioIndexViewModel
    {

        public int Id { get; set; }

        [Display(Name = "Login do Usuário")]
        public string Login { get; set; }
        [Display(Name = "Nome do Usuário")]
        public string Nome { get; set; }
        [Display(Name = "Usuário Ativo")]
        public Boolean Status { get; set; }

    }
}