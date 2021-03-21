using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myWebsite.Models
{
    public class Student
    {
        [Display(Name = "ID")]
        public string StudentID { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        [Display(Name = "Class")]
        public string ClassName { get; set; }
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Nam")]
        public bool Sex { get; set; }
    }
}