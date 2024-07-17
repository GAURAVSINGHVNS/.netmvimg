namespace mvcimg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblregistrations",
                c => new
                    {
                        rid = c.Int(nullable: false, identity: true),
                        rname = c.String(),
                        remail = c.String(),
                        rpassword = c.String(),
                        rimg = c.String(),
                    })
                .PrimaryKey(t => t.rid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblregistrations");
        }
    }
}
