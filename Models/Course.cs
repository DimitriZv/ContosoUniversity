using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /* DatabaseGenerated attribute allows the app to specify 
        the primary key rather than having the database generate it.*/
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; } //foreign key //course is assigned to one department DepartmentID is FK

        public Department Department { get; set; } //this is a navigation property
        public ICollection<Enrollment> Enrollments { get; set; } //collection of students enrollments
        public ICollection<Instructor> Instructors { get; set; }
    }
}