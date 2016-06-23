﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movie_express.Pages.admin
{
    public partial class cadastro_produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Salvar_Produto_Click(object sender, EventArgs e)
        {
            movie_express.bancoEntities1 banco = new movie_express.bancoEntities1();

            TB_PROD produto = new TB_PROD();

            produto.PROD_TITULO = Titulo_Prod.Text;
            produto.PROD_GENERO = Genero_Prod.Text;
            produto.PROD_ANOLAN = int.Parse(Ano_Lanc_Prod.Text);
            produto.PROD_SINOPS = Sinipse_Prod.Text;
            produto.PROD_PRECO = decimal.Parse(Preco_Prod.Text);
            produto.PROD_QTDEST = int.Parse(Qtd_Estoque.Text);
            produto.PROD_IMDB = int.Parse(Nota_Imdb.Text);

            banco.TB_PROD.Add(produto);
            banco.SaveChanges();


        }
    }
}