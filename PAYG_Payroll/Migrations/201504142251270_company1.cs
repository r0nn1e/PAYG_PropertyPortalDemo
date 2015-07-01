namespace PAYG_Payroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class company1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Companies");
            AddColumn("dbo.Companies", "comp_id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Companies", "comp_name", c => c.String());
            AddPrimaryKey("dbo.Companies", "comp_id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Companies");
            AlterColumn("dbo.Companies", "comp_name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Companies", "comp_id");
            AddPrimaryKey("dbo.Companies", "comp_name");
        }
    }
}
