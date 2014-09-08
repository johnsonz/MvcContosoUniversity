using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
            [Key]
            [ForeignKey("Instructor")]
            public int InstructorID { get; set; }
            [StringLength(50)]
            [Display(Name = "Office Location")]
            public string Location { get; set; }

            public virtual Instructor Instructor { get; set; }
        
    }
}