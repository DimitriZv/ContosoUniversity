using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key] //Be a single property a Primary Key. not piblic string Id { get; set; }
        public int InstructorID { get; set; } //in this example InstructorID is a PK, which is PK for Instructor as well
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}