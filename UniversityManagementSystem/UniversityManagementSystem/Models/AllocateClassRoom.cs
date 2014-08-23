using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class AllocateClassRoom
    {
        public int AllocateClassRoomId { get; set; }
        [Required(ErrorMessage = "Please select department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        [Required(ErrorMessage = "please select Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required(ErrorMessage = " Please Select Room")]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        [Required(ErrorMessage = " Please Select a Day")]
        public int DayId { get; set; }
        public virtual Day Day { get; set; }
        [Required(ErrorMessage = "Please enter Start Time")]
        
        [RegularExpression((@"^(20|21|22|23|[01]\d|\d)(([:][0-5]\d){1,2})$"), ErrorMessage = "Please enter a valid time")]
        
        public string StartTime { get; set; }
        
        [Required(ErrorMessage = "Please Enter End Time")]
        [RegularExpression((@"^(20|21|22|23|[01]\d|\d)(([:][0-5]\d){1,2})$"), ErrorMessage = "Please enter a valid time")]
        
        public string EndTime { get; set; }

    }
}