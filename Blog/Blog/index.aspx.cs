using Blog.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button_Click(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                Post post = new Post();
                post.Titulo = " Teste ";
                post.Conteudo = " Comentário ";

                contexto.Posts.Add(post);
                contexto.SaveChanges();
            };

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("WebForm2.aspx");
        }
    }
    }