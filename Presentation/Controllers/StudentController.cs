using ProEntity;
using ProService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        ProService.IStudentService service = ServiceFactory.GetStudentService();
        ProService.ISectionService service2 = ServiceFactory.GetSectionService();
        ProService.ICourseService service3 = ServiceFactory.GetCourseService();
        ProService.IGradeService grservice = ServiceFactory.GetGradeService();
        ProService.IStudentSectionService service4 = ServiceFactory.GetStudentSectionService();

        public ActionResult Index()
        {
            Student st = service.Get(Convert.ToInt32(Session["id"]));
            return View(st);
        }
        public ActionResult LogOut()
        {
            Session["id"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Courses()
        {
            List<StudentSection> ss = service4.GetByStu(Convert.ToInt32(Session["id"])).ToList();
            List<Section> allsec = service2.GetAll().ToList();
            List<Section> newsec = new List<Section>();
            foreach (var sst in ss) {
                foreach (var allsect in allsec) {
                    if (sst.SecId == allsect.SecId) {
                        newsec.Add(allsect);
                    }
                }
            }

            List<Course> allc = service3.GetAll().ToList();
            List<Course> newc = new List<Course>();
            foreach (var sst in newsec)
            {
                foreach (var allct in allc)
                {
                    if (sst.CourseId == allct.CourseId)
                    {
                        newc.Add(allct);
                    }
                }
            }

            List<Grade> gr = grservice.GetAll().ToList();
            List<Grade> newgr = new List<Grade>();
            foreach (var g in gr)
            {
                if (g.StuId == Convert.ToInt32(Session["id"]))
                {
                    newgr.Add(g);

                }

            }

            Models.ForStudent ms = new Models.ForStudent();
            ms.course = newc;
            ms.section = newsec;
            ms.gr = newgr;
            
            var all = newsec.Where(b => ss.Any(a => a.SecId == b.SecId));
            List<Section> join1 = all.ToList();
            return View(newc);
        }
        public ActionResult Grades(int id) {
            List<Section> sc = service2.GetAll().ToList();
            List<Section> news = new List<Section>();
            foreach (var v in sc)
            {
                if (v.CourseId == id) {
                    news.Add(v);
                }
            }
            List<StudentSection> sts = service4.GetAll().ToList();
            StudentSection nsts = new StudentSection();
            foreach (var v in sts)
            {
                foreach(var vs in news)
                if (v.SecId == vs.SecId && v.StuId == Convert.ToInt32(Session["id"]))
                {
                    nsts = v;
                }
            }
            List<Grade> grd = grservice.GetAll().ToList();
            Grade grds = new Grade();
            foreach (var g in grd) {
                if (g.SecId == nsts.SecId) {
                    grds = g;
                }
            }
            return View(grds);
        }

    }
}
