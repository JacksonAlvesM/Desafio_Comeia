using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;

namespace Desafio.Models
{
    public class Empresas
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome_Fantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Data do cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_Do_Cadastro { get; set; }

        public Empresas()
        {
            Data_Do_Cadastro = DateTime.Now;
        }
        











    }
}