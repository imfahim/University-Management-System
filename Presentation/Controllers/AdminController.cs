using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProService;
using ProEntity;
namespace Presentation.Controllers
{
    public class AdminController : Controller
    {
        ProService.IAdminService service = ServiceFactory.GetAdminService();
        ProService.IFacultyService Fservice = ServiceFactory.GetFacultyService();
        ProService.ICourseService Cservice = ServiceFactory.GetCourseService();
        ProService.ISectionService Sservice = ServiceFactory.GetSectionService();
        ProService.IStudentService Stservice = ServiceFactory.GetStudentService();
        ProService.IStudentSectionService STCservice = ServiceFactory.GetStudentSectionService();
        ProService.IReportService rpservice = ServiceFactory.GetReportService();
        ProService.IAttendenceService Atservice = ServiceFactory.GetAttendenceService();
        ProService.IGradeService grservice = ServiceFactory.GetGradeService();







        //

        // GET: /Admin/

        public ActionResult Index()
        {
            if (Session["id"] == null) {
                return RedirectToAction("Index", "Home");
            }
            return View(service.GetAll());
        }
        public ActionResult LogOut()
        {
            Session["id"] = null;
            return RedirectToAction("Index", "Home"); 
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Admin co)
        {
            if (ModelState.IsValid)
            {
                service.Insert(co);
                return RedirectToAction("Index");
            }
            else
            {
                return View(co);
            }
        }
        [HttpGet]
        public ActionResult CreateCourse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCourse(Course co)
        {
            if (ModelState.IsValid)
            {
                Cservice.Insert(co);
                return RedirectToAction("Index");
            }
            else
            {
                return View(co);
            }
        }
      
        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student co)
        {
            if (ModelState.IsValid)
            {
                Stservice.Insert(co);
                return RedirectToAction("Student");
            }
            else
            {
                return View(co);
            }
        }
        [HttpGet]
        public ActionResult CreateFac()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFac(Faculty co)
        {
            if (ModelState.IsValid)
            {
                Fservice.Insert(co);
                return RedirectToAction("Faculty");
            }
            else
            {
                return View(co);
            }
        }
        [HttpGet]
        public ActionResult EditPass(int id)
        {
            Admin ad = service.Get(id);
            return View(ad);
        }
        [HttpPost]
        public ActionResult EditPass(Admin co)
        {
            if (ModelState.IsValid)
            {
                service.Update(co);
                return RedirectToAction("Index");
            }
            else
            {
                return View(co);
            }
        }


        [HttpGet]
        public ActionResult EditFac(int id)
        {
            Faculty ad = Fservice.Get(id);
            return View(ad);
        }
        [HttpPost]
        public ActionResult EditFac(Faculty co)
        {
            if (ModelState.IsValid)
            {
                Fservice.Update(co);
                return RedirectToAction("Faculty");
            }
            else
            {
                return View(co);
            }
        }

        [HttpGet]
        public ActionResult EditSec(int id)
        {
            Section ad = Sservice.Get(id);
            return View(ad);
        }


        [HttpPost]
        public ActionResult EditSec(Section co)
        {
            if (ModelState.IsValid)
            {
                Sservice.Update(co);
                return RedirectToAction("Faculty");
            }
            else
            {
                return View(co);
            }
        }
        [HttpGet]
        public ActionResult DeleteSec(int id)
        {
            Section sec = Sservice.Get(id);
            return View(sec);
           
        }
        [HttpPost, ActionName("DeleteSec")]
        public ActionResult ConfirmDelete1(int id)
        {
            Sservice.Delete(id);
            return RedirectToAction("Courses");
        }
        [HttpGet]
        public ActionResult EditCourse(int id)
        {
            Course ad = Cservice.Get(id);
            return View(ad);
        }


        [HttpPost]
        public ActionResult EditCourse(Course co)
        {
            if (ModelState.IsValid)
            {
                Cservice.Update(co);
                return RedirectToAction("Courses");
            }
            else
            {
                return View(co);
            }
        }

        
        [HttpGet]
        public ActionResult DeleteStu(int id)
        {
            Student st= Stservice.Get(id);
            List<StudentSection> ss = STCservice.GetAll().ToList();

            foreach (var t in ss) {
                if (t.StuId == id) {
                    STCservice.Delete(t.StuSec);
                }
            }
            List<Attendence> ast = Atservice.GetAll().ToList();

            foreach (var t in ast)
            {
                if (t.StudentId == id)
                {
                    Atservice.Delete(t.AttId);
                }
            }
            Stservice.Delete(id);
            return RedirectToAction("Student");
        }

        
            [HttpGet]
            public ActionResult DeleteRep(int id)
        {
            Report cs = rpservice.Get(id);
            rpservice.Delete(id);
            return RedirectToAction("Report");
        }

        [HttpGet]
        public ActionResult DeleteCourse(int id)
        {
            Course cs = Cservice.Get(id);
            Cservice.Delete(id);
            return View(cs);
        }
        [HttpPost, ActionName("DeleteCourse")]
        public ActionResult ConfirmDelete(int id)
        {
            Cservice.Delete(id);
            return RedirectToAction("Courses");
        }
        
        [HttpGet]
        public ActionResult StudentList(int id)
        {

            List<StudentSection> secs = STCservice.GetBySec(id).ToList();
            
            return View(secs);
        }
        [HttpGet]
        public ActionResult DetailsInCourse(int id)
        {
            List<Section> sc = new List<Section>();
            List<Section> secs = Sservice.GetAll().ToList();
            foreach (var it in secs) {
                if (it.CourseId == id) {
                    sc.Add(it);
                }
            }
            return View(sc);
        }
        

        [HttpGet]
        public ActionResult Faculty()
        {
            return View(Fservice.GetAll());
        }
        [HttpGet]
        public ActionResult Report()
        {
            return View(rpservice.GetAll());
        }
        [HttpGet]
        public ActionResult Student()
        {
            return View(Stservice.GetAll());
        }
        [HttpGet]
        public ActionResult Courses()
        {
            return View(Cservice.GetAll());
        }

        [HttpGet]
        public ActionResult AddSection() {
            List<SelectListItem> Facultylist = new List<SelectListItem>();
            List<Faculty> fc = Fservice.GetAll().ToList();
            foreach (var d in fc)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = d.FacultyName,
                    Value = d.FacultyId.ToString()
                };
                Facultylist.Add(item);
            }
            ViewBag.Faculties = Facultylist;

            List<SelectListItem> Courselist = new List<SelectListItem>();
            List<Course> cs = Cservice.GetAll().ToList();
            foreach (var d in cs)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = d.CourseName,
                    Value = d.CourseId.ToString()
                };
                Courselist.Add(item);
            }
            ViewBag.Courses = Courselist;

            return View();
        }
        [HttpPost]
        public ActionResult AddSection(Section sec)
        {
            if (ModelState.IsValid)
            {
                Sservice.Insert(sec);
      
                return RedirectToAction("Index");
            }
            else
            {
                return View(sec);
            }
        }


        [HttpGet]
        public ActionResult AddStudentToSection()
        {
            List<SelectListItem> Sectionlist = new List<SelectListItem>();
            List<Section> sc = Sservice.GetAll().ToList();
            foreach (var d in sc)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = d.SecName,
                    Value = d.SecId.ToString()
                };
                Sectionlist.Add(item);
            }
            ViewBag.Sections = Sectionlist;

            List<SelectListItem> Studentlist = new List<SelectListItem>();
            List<Student> st = Stservice.GetAll().ToList();
            foreach (var d in st)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = d.StuName + "("+d.StuId+")",
                    Value = d.StuId.ToString()
                };
                Studentlist.Add(item);
            }
          
            ViewBag.Students = Studentlist;
            return View();
        }
        [HttpPost]
        public ActionResult AddStudentToSection(StudentSection sec)
        {
            if (ModelState.IsValid)
            {
                STCservice.Insert(sec);
                Student ats = Stservice.Get(sec.StuId);
                Section sc = Sservice.Get(sec.SecId);
                Attendence ast = new Attendence();

                ast.StudentId = ats.StuId;
                ast.SecId = sc.SecId;
                ast.Attend = 0;
                ast.AttendCounter = 0;
                int val = Convert.ToInt32(sc.CourseId);
                ast.CourseId = val;
                ast.Date = DateTime.Now;
                Atservice.Insert(ast);


                Grade gr = new Grade();
                gr.SecId = sc.SecId;
                gr.StuId = ats.StuId;
                gr.grade = 0;
                
                grservice.Insert(gr);


                return RedirectToAction("Index");
            }
            else
            {
                return View(sec);
            }
        }
 



    }
}
