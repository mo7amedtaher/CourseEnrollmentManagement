using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CourseEnrollmentManagement.Models;



namespace CourseEnrollmentManagement.DAL
{
    public class UniversityContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        
    }
    
}