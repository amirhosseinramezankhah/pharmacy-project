namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitnTonRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductInvoices", "Product_id", "dbo.Products");
            DropForeignKey("dbo.ProductInvoices", "Invoice_id", "dbo.Invoices");
            DropIndex("dbo.ProductInvoices", new[] { "Product_id" });
            DropIndex("dbo.ProductInvoices", new[] { "Invoice_id" });
            CreateTable(
                "dbo.InvoiceProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.InvoiceID);
            
            DropTable("dbo.ProductInvoices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductInvoices",
                c => new
                    {
                        Product_id = c.Int(nullable: false),
                        Invoice_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_id, t.Invoice_id });
            
            DropForeignKey("dbo.InvoiceProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.InvoiceProducts", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.InvoiceProducts", new[] { "InvoiceID" });
            DropIndex("dbo.InvoiceProducts", new[] { "ProductID" });
            DropTable("dbo.InvoiceProducts");
            CreateIndex("dbo.ProductInvoices", "Invoice_id");
            CreateIndex("dbo.ProductInvoices", "Product_id");
            AddForeignKey("dbo.ProductInvoices", "Invoice_id", "dbo.Invoices", "id", cascadeDelete: true);
            AddForeignKey("dbo.ProductInvoices", "Product_id", "dbo.Products", "id", cascadeDelete: true);
        }
    }
}
