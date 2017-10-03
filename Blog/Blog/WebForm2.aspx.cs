using Blog.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                var posts = contexto.Posts.ToList();
                foreach (var item in posts)
                {
                    Response.Write(item.Titulo);
                    Response.Write(item.Conteudo);
                }
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}