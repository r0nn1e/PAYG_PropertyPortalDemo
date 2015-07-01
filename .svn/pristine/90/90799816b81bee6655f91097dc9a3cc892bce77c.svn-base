namespace PAYG_Payroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hmrc_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "comp_hmrcusername", c => c.String());
            AddColumn("dbo.Companies", "comp_hmrcpassword", c => c.String());
            AddColumn("dbo.Companies", "comp_normalpaydayMonth", c => c.String());
            AddColumn("dbo.Companies", "comp_normalpaydayweek", c => c.String());
            AddColumn("dbo.Companies", "comp_employerallowance", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "comp_employerallowance");
            DropColumn("dbo.Companies", "comp_normalpaydayweek");
            DropColumn("dbo.Companies", "comp_normalpaydayMonth");
            DropColumn("dbo.Companies", "comp_hmrcpassword");
            DropColumn("dbo.Companies", "comp_hmrcusername");
        }
    }
}
