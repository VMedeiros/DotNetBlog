namespace Blog
{
    using Blog.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MeuContexto : DbContext
    {
        // Your context has been configured to use a 'MeuContexto' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Blog.MeuContexto' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MeuContexto' 
        // connection string in the application configuration file.
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }


        public MeuContexto()
            : base("name=MeuContexto")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}