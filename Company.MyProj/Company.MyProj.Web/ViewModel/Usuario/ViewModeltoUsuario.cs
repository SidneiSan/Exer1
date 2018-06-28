using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Company.MyProj.Web.ViewModel.Usuario
{
    public class ViewModeltoUsuario
    {

        [Required(ErrorMessage ="O Id é obrigatório")]
        public int Id { get; set; }

        [Display(Name = "Login do Usuário")]
        [Required(ErrorMessage = "O Login é Obrigatório")]
        public string Login { get; set; }

        [Display(Name = "Nome do Usuário")]
        [MaxLength(100, ErrorMessage ="O tamanha máximo é de 100 carecteres")]
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Usuário Ativo")]
        [Required(ErrorMessage = "O Status é Obrigatório")]
        public Boolean Status { get; set; }


    }
}