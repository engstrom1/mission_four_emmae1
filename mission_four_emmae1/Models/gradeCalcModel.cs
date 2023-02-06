using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission_four_emmae1.Models
{
    public class gradeCalcModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double assignments { get; set; }
        
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double groupProject{ get; set; }
        
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double quizzes{ get; set; }
        
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double midtermExam{ get; set; }
        
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double finalExam{ get; set; }
        
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public double intex{ get; set; }
    }
}
