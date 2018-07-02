using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProEntity;
using ProService;

namespace Presentation.Controllers
{
    public class FacultyController : Controller
    {
        //
        // GET: /Faculty/
        ProService.IFacultyService Fservice = ServiceFactory.GetFacultyService();
        ProService.IStudentService Stservice = ServiceFactory.GetStudentService();
        ProService.IAttendenceService Atservice = ServiceFactory.GetAttendenceService();
        ProService.IReportService rpservice = ServiceFactory.GetReportService();


        ProService.ISectionService Sservice = ServiceFactory.GetSectionService();
        ProService.ICourseService Cservice = ServiceFactory.GetCourseService();
        ProService.IGradeService grservice = ServiceFactory.GetGradeService();

        ProService.IStudentSectionService SSservice = ServiceFactory.GetStudentSectionService();

        public ActionResult Index()
        {
            Faculty ff = Fservice.Get(Convert.ToInt32(Session["id"]));
            return View(ff);
        }
        public ActionResult LogOut()
        {
            Session["id"] = null;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult CourseSections()
        {
            List<Section> sc = Sservice.GetByFaculty(Convert.ToInt32(Session["id"]));
            return View(sc);

        }
        public ActionResult StudentList(int id)
        {
            List<StudentSection> sc = SSservice.GetBySec(id).ToList();
            List<Student> st = Stservice.GetAll().ToList();
            List<Student> nst = new List<Student>();
            foreach (var isc in sc)
            {
                foreach (var ist in st)
                {
                    if (isc.StuId == ist.StuId)
                    {
                        nst.Add(ist);
                    }
                }
            }
            return View(nst);

        }
        public ActionResult Grade(int id)
        {
            List<StudentSection> sc = SSservice.GetByStu(id).ToList();
            List<Section> ss = Sservice.GetAll().ToList();
            List<Section> nst = new List<Section>();
            foreach (var isc in sc)
            {
                foreach (var ist in ss)
                {
                    if (isc.SecId == ist.SecId && ist.FacultyId == Convert.ToInt32(Session["id"]))
                    {
                        nst.Add(ist);
                    }
                }
            }
            List<Grade> gr = grservice.GetAll().ToList();
            List<Grade> grd = new List<Grade>();
            foreach (var v in gr)
            {
                foreach (var vr in nst)
                {
                    if (v.SecId == vr.SecId)
                    {
                        grd.Add(v);
                    }
                }
            }
            return View(grd);
        }

        [HttpGet]
        public ActionResult EditGrade(int id)
        {
            Grade ad = grservice.Get(id);
            return View(ad);
        }

        
        [HttpPost]
        public ActionResult EditGrade(Grade co)
        {
            if (ModelState.IsValid)
            {
                grservice.Update(co);
                return RedirectToAction("CourseSections");
            }
            else
            {
                return View(co);
            }
        }

        public ActionResult Attendence(int id)
        {
            List<Attendence> at = Atservice.GetAll().ToList();
            List<Attendence> nat = new List<ProEntity.Attendence>();
            Session["AtId"] = id;
            foreach (var t in at)
            {
                if (t.SecId == id)
                {
                    nat.Add(t);
                }
            }
            return View(nat);
        }
        public ActionResult GiveAttend(int id)
        {
            Attendence at = Atservice.Get(id);
            ;
            if (at.Date.ToString("dd.MM.yyy") == DateTime.Now.ToString("dd.MM.yyy"))
            {
                at.Attend = 0;
                Atservice.Update(at);
            }
            else
            {
                if (at.Attend == 0)
                {
                    at.Attend = 1;
                    at.AttendCounter++;
                    at.Date = DateTime.Now;
                }
                else if (at.Attend == 1)
                {
                    at.Attend = 0;
                    at.AttendCounter--;
                }
                Atservice.Update(at);
            }
            return RedirectToAction("Attendence", new { id = Convert.ToInt32(Session["AtID"]) });
        }

        [HttpGet]
        public ActionResult DropCourse(int id)
        {
           List<StudentSection> sst= SSservice.GetByStu(id).ToList();
           List<Section> sec = Sservice.GetAll().ToList();
            StudentSection nsst= new StudentSection();
            foreach(var t in sec){
                foreach(var it in sst){
                    if(it.SecId==t.SecId && t.FacultyId==Convert.ToInt32(Session["id"])){
                        nsst=it;
                    }
                }
            }
           return View(nsst);
        }
        [HttpPost, ActionName("DropCourse")]
        public ActionResult ConfirmDrop(int id)
        {
            List<StudentSection> sst = SSservice.GetByStu(id).ToList();
            List<Section> sec = Sservice.GetAll().ToList();
            StudentSection nsst = new StudentSection();
            Section s = new Section();
            foreach (var t in sec)
            {
                foreach (var it in sst)
                {
                    if (it.SecId == t.SecId && t.FacultyId == Convert.ToInt32(Session["id"]))
                    {
                        nsst = it;
                        s = t;
                    }
                }
            }
            SSservice.Delete(nsst.StuSec);
            List<Attendence> ast = Atservice.GetAll().ToList();

            foreach (var t in ast)
            {
                if (t.StudentId == id && s.SecId== t.SecId)
                {
                    Atservice.Delete(t.AttId);
                }
            }
            Report rp = new Report();
            rp.StuId = nsst.StuId;
            rp.Comment = "Course Dropped!! Sec Id= "+s.SecId+" Sec Name="+s.SecName;
            rpservice.Insert(rp);
            return RedirectToAction("Index");
        }
    }
}
