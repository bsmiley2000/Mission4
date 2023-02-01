using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4ModelValidation.Models
{
    public class GradeModel
    {

        [Key]
        public int Id { get; set; }

        [Range(0, 100, ErrorMessage = "Can only be between 0 .. 100")]
        public int Assignments { get; set; }

        [Range(0, 100, ErrorMessage = "Can only be between 0 .. 100")]
        public int Quizzes { get; set; }

        [Range(0, 100, ErrorMessage = "Can only be between 0 .. 100")]
        public int Group_projects { get; set; }

        [Range(0, 100, ErrorMessage = "Can only be between 0 .. 100")]
        public int Intex { get; set; }

        [Range(0, 100, ErrorMessage = "Can only be between 0 .. 100")]
        public int Midterm { get; set; }

        [Range(0, 100, ErrorMessage = "Can only be between 0 .. 100")]
        public int Final_exam { get; set; }

    }
}
