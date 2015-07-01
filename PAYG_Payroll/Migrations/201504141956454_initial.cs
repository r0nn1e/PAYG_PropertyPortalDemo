namespace PAYG_Payroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salutation = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        KnownAs = c.String(),
                        Add1 = c.String(),
                        Add2 = c.String(),
                        Add3 = c.String(),
                        City = c.String(),
                        County = c.String(),
                        PostCode = c.String(),
                        HomeTel = c.String(),
                        Mobile = c.String(),
                        NiNo = c.String(),
                        TaxCodeNumber = c.Int(nullable: false),
                        TaxCodeLetter = c.String(),
                        TaxCodePrefix = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        payRate = c.Double(nullable: false),
                        HolidayRate = c.Double(nullable: false),
                        MileRate = c.Double(nullable: false),
                        StaffActive = c.Boolean(nullable: false),
                        IncludeInPayroll = c.Boolean(nullable: false),
                        GrossPayToDate = c.Double(nullable: false),
                        TaxablePayToDate = c.Double(nullable: false),
                        TaxPaidToDate = c.Double(nullable: false),
                        NiPaidToDate = c.Double(nullable: false),
                        WeekOneMonthOne = c.Boolean(nullable: false),
                        HolidayEntitlementCurrentYear = c.Double(nullable: false),
                        HolidayTakenCurrentYear = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payslips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ps_id = c.Int(nullable: false),
                        ps_week_no = c.Int(nullable: false),
                        ps_date_paid = c.DateTime(nullable: false),
                        ps_staff_name = c.String(),
                        ps_staff_id = c.Int(nullable: false),
                        ps_basic_1 = c.Double(nullable: false),
                        ps_rate_1 = c.Double(nullable: false),
                        ps_pay_1 = c.Double(nullable: false),
                        ps_basic_2 = c.Double(nullable: false),
                        ps_rate_2 = c.Double(nullable: false),
                        ps_pay_2 = c.Double(nullable: false),
                        ps_distance = c.Int(nullable: false),
                        ps_mile_rate = c.Double(nullable: false),
                        ps_mile_pay = c.Double(nullable: false),
                        ps_advance_paid = c.Double(nullable: false),
                        ps_tax = c.Double(nullable: false),
                        ps_ni = c.Double(nullable: false),
                        ps_gross_pay = c.Double(nullable: false),
                        ps_nett_pay = c.Double(nullable: false),
                        ps_gross_to_date = c.Double(nullable: false),
                        ps_tax_to_date = c.Double(nullable: false),
                        ps_ni_to_date = c.Double(nullable: false),
                        ps_non_taxable_extra = c.Double(nullable: false),
                        ps_non_taxable_extra_reason = c.Double(nullable: false),
                        ps_taxable_extra = c.Double(nullable: false),
                        ps_taxable_extra_reason = c.String(),
                        ps_prev_tax_free_TD = c.Double(nullable: false),
                        ps_new_tax_free_TD = c.Double(nullable: false),
                        ps_employer_NIC = c.Double(nullable: false),
                        ps_sick_pay_days = c.Int(nullable: false),
                        ps_sick_pay_amount = c.Double(nullable: false),
                        ps_holiday_hours = c.Double(nullable: false),
                        ps_holiday_amount = c.Double(nullable: false),
                        ps_hol_days = c.Double(nullable: false),
                        ps_hol_rate = c.Double(nullable: false),
                        ps_tax_code = c.Int(nullable: false),
                        ps_tax_text = c.String(),
                        ps_tax_letter = c.String(),
                        ps_year = c.Int(nullable: false),
                        ps_hol_accrued = c.Double(nullable: false),
                        ps_hol_taken = c.Double(nullable: false),
                        ps_hol_left = c.Double(nullable: false),
                        ps_act_hours = c.Double(nullable: false),
                        ps_paid_hmrc = c.Double(nullable: false),
                        ps_calc_accrued = c.Double(nullable: false),
                        ps_text_1 = c.String(),
                        ps_text_2 = c.String(),
                        ps_text_3 = c.String(),
                        ps_basic_3 = c.Double(nullable: false),
                        ps_rate_3 = c.Double(nullable: false),
                        ps_pay_3 = c.Double(nullable: false),
                        ps_month_no = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PayWeeks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PayDate = c.DateTime(nullable: false),
                        Year = c.String(),
                        WeekNumber = c.Int(nullable: false),
                        RotaWeek = c.Int(nullable: false),
                        IsProcessed = c.Int(nullable: false),
                        Branch = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PayWeeks");
            DropTable("dbo.Payslips");
            DropTable("dbo.Employees");
        }
    }
}
