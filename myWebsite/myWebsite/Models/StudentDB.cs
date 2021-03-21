using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace myWebsite.Models
{
    public class StudentDB
    {
        private List<Student> list;

        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }


        public StudentDB()
        {
            list = new List<Student>()
            {
            new Student(){
                StudentID = "111",
                StudentName = "Nguyen Van A",
                ClassName = "20CT111",
                Sex = true,
                Age = 19,
                Birthday = new DateTime(2001,4,5)},
            new Student(){
                StudentID = "112",
                StudentName = "Phan Thi B",
                ClassName = "19CT111",
                Sex = false,
                Age = 20,
                Birthday = new DateTime(2000,9,8)},
            new Student(){
                StudentID = "113",
                StudentName = "Nguyen Van C",
                ClassName = "18CT113",
                Sex = true,
                Age = 21,
                Birthday = new DateTime(2000,4,5)
            }
            
        };
        }
       public List<Student> GetStudents()
        {
            return list;
        }
    }
}