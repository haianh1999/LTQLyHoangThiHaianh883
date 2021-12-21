namespace LTQL_1721050883.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HTHASanPham883",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 20),
                        TenSanPham = c.String(maxLength: 50),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap883", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
            CreateTable(
                "dbo.NhaCungCap883",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HTHASanPham883", "MaNhaCungCap", "dbo.NhaCungCap883");
            DropIndex("dbo.HTHASanPham883", new[] { "MaNhaCungCap" });
            DropTable("dbo.NhaCungCap883");
            DropTable("dbo.HTHASanPham883");
        }
    }
}
