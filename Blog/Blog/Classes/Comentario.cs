using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Classes
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public Post Post { get; set; }
    }


}