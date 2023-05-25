namespace Lab3B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idk1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DoctorPatients", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.DoctorPatients", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.HospitalDoctors", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.HospitalDoctors", "HospitalId", "dbo.Hospitals");
            DropIndex("dbo.DoctorPatients", new[] { "PatientId" });
            DropIndex("dbo.DoctorPatients", new[] { "Doctor_Id" });
            DropIndex("dbo.HospitalDoctors", new[] { "HospitalId" });
            DropIndex("dbo.HospitalDoctors", new[] { "DoctorId" });
            DropTable("dbo.DoctorPatients");
            DropTable("dbo.HospitalDoctors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HospitalDoctors",
                c => new
                    {
                        HospitalDoctorId = c.Int(nullable: false, identity: true),
                        HospitalId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HospitalDoctorId);
            
            CreateTable(
                "dbo.DoctorPatients",
                c => new
                    {
                        DoctoerPatientId = c.Int(nullable: false, identity: true),
                        DoctoerId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        Doctor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DoctoerPatientId);
            
            CreateIndex("dbo.HospitalDoctors", "DoctorId");
            CreateIndex("dbo.HospitalDoctors", "HospitalId");
            CreateIndex("dbo.DoctorPatients", "Doctor_Id");
            CreateIndex("dbo.DoctorPatients", "PatientId");
            AddForeignKey("dbo.HospitalDoctors", "HospitalId", "dbo.Hospitals", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HospitalDoctors", "DoctorId", "dbo.Doctors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DoctorPatients", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DoctorPatients", "Doctor_Id", "dbo.Doctors", "Id");
        }
    }
}
