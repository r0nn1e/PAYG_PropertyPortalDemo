namespace PAYG_Payroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class company : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        comp_name = c.String(nullable: false, maxLength: 128),
                        comp_add1 = c.String(),
                        comp_add2 = c.String(),
                        comp_add3 = c.String(),
                        comp_add4 = c.String(),
                        comp_towncity = c.String(),
                        comp_county = c.String(),
                        comp_postcode = c.String(),
                        comp_bankname = c.String(),
                        comp_sortcode = c.String(),
                        comp_accountnum = c.String(),
                        comp_payeref = c.String(),
                        comp_payeaccount = c.String(),
                    })
                .PrimaryKey(t => t.comp_name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}
