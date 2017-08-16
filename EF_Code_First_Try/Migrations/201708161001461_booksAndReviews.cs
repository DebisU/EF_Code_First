namespace EF_Code_First_Try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class booksAndReviews : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Review", "BookID", "dbo.Books");
            DropIndex("dbo.Review", new[] { "BookID" });
            CreateTable(
                "dbo.ReviewBooks",
                c => new
                    {
                        Review_ReviewID = c.Int(nullable: false),
                        Book_BookID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Review_ReviewID, t.Book_BookID })
                .ForeignKey("dbo.Review", t => t.Review_ReviewID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookID, cascadeDelete: true)
                .Index(t => t.Review_ReviewID)
                .Index(t => t.Book_BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewBooks", "Book_BookID", "dbo.Books");
            DropForeignKey("dbo.ReviewBooks", "Review_ReviewID", "dbo.Review");
            DropIndex("dbo.ReviewBooks", new[] { "Book_BookID" });
            DropIndex("dbo.ReviewBooks", new[] { "Review_ReviewID" });
            DropTable("dbo.ReviewBooks");
            CreateIndex("dbo.Review", "BookID");
            AddForeignKey("dbo.Review", "BookID", "dbo.Books", "BookID", cascadeDelete: true);
        }
    }
}
