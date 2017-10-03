namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Conteudo = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        ComentarioID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Conteudo = c.String(),
                        Post_PostID = c.Int(),
                    })
                .PrimaryKey(t => t.ComentarioID)
                .ForeignKey("dbo.Posts", t => t.Post_PostID)
                .Index(t => t.Post_PostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "Post_PostID", "dbo.Posts");
            DropIndex("dbo.Comentarios", new[] { "Post_PostID" });
            DropTable("dbo.Comentarios");
            DropTable("dbo.Posts");
        }
    }
}
