using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    

    public class StudentController : Controller
    {
        string strConnection = "";


        // GET: Student
        public ActionResult Index()
        {
            //Query Model
            List<Student> results = null;
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                string strSql = "Select * from Student";
                results = conn.Query<Student>(strSql).ToList();
            }

            return View(results);
        }
    }
}