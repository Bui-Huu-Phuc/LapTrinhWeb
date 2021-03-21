using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myWebsite.Models;
using System.Data.SqlClient;
namespace myWebsite.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentWithoutSql()
        {
            var student = new StudentDB().GetStudents();
            TempData["Student"] = student;
            TempData.Keep();
            return View();
        }
        public ActionResult StudentByID(string StudentID)
        {
            var StudentList = TempData["Student"] as List<Student>;
            var _student = StudentList.SingleOrDefault(x => x.StudentID == StudentID);
            TempData["Student"] = _student;
            return View();
        }
        public ActionResult StudentWithSQL()
        {
            var _student = new UsingSQL().GetStudentList("PSP_Student_GetStudent", System.Data.CommandType.StoredProcedure, null);
            List<Student> list = new List<Student>();
            while (_student.Read())
            {
                list.Add(new Student()
                {

                    StudentID = _student["ID"].ToString(),
                    StudentName = _student["Name"].ToString(),
                    Age = Convert.ToInt32(_student["Age"].ToString()),
                    Sex = Convert.ToBoolean(_student["Sex"].ToString()),
                    Birthday = Convert.ToDateTime(_student["Birthday"].ToString()),
                    ClassName = _student["Class"].ToString()

                });
            }
            return View(list);
        }
    }     
}