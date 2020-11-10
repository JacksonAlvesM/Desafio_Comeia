using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.DAO
{
   public class InicializadorEmpresas : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpresasContext>
    {
        protected override void Seed(EmpresasContext context)
        {
            var empresas = new List<Empresas>
            {
            new Empresas{CNPJ="05634564000108", Nome_Fantasia="02 EVENTOS ORGANIZAÇÃO E PROD LTDA ME",Telefone="995683265", Email="empresa01@gmail.com", Data_Do_Cadastro= DateTime.Now},
            new Empresas{CNPJ="05634564000108", Nome_Fantasia="AMKG BRASIL EIRELI LTDA ME",Telefone="995562868", Email="empresa02@gmail.com", Data_Do_Cadastro= DateTime.Now},
            new Empresas{CNPJ="05634564000108", Nome_Fantasia="ANDERSON MENDONCA DA SILVA",Telefone="985624350", Email="empresa03@gmail.com", Data_Do_Cadastro= DateTime.Now},            
            new Empresas{CNPJ="05634564000108", Nome_Fantasia="ANDERSON MENDONCA DA SILVA",Telefone="984523063", Email="empresa04@gmail.com", Data_Do_Cadastro= DateTime.Now},            
            new Empresas{CNPJ="05634564000108", Nome_Fantasia="ANDERSON MENDONCA DA SILVA",Telefone="97824526", Email="empresa05@gmail.com", Data_Do_Cadastro= DateTime.Now},          
            };

            empresas.ForEach(s => context.Empresas.Add(s));
            context.SaveChanges();
           
        }
    }
}
