using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProService;
using ProEntity;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {

        ProService.IAdminService service = ServiceFactory.GetAdminService();
        ProService.IStudentService Sservice = ServiceFactory.GetStudentService();
        ProService.IFacultyService Fservice = ServiceFactory.GetFacultyService();


    
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
       // [HttpGet]
        public ActionResult Login(string SelectType,string id,string password)
        {
            if (id == "" || password == "")
            {
                TempData["msg"] = "<script>alert('Fill All Fields');</script>";
                return RedirectToAction("Index");
            }
            else
            {
                if (SelectType == "1")
                {
                    IEnumerable<Admin> admin = service.GetAll();
                    foreach (Admin ad in admin)
                    {
                        if (ad.AdminId == Convert.ToInt32(id) && ad.APassword == password)
                        {
                            Session["id"] = Convert.ToInt32(id);
                            return RedirectToAction("Index", "Admin");
                        }
                        else{
                            TempData["msg"] = "<script>alert('Incorrect Username Or Password');</script>";
                            return RedirectToAction("Index");
                        }
                    }
                }
                else if (SelectType == "2")
                {
                    IEnumerable<Student> admin = Sservice.GetAll();
                    foreach (Student ad in admin)
                    {
                        if (ad.StuId == Convert.ToInt32(id) && ad.StuPass == password)
                        {
                            Session["id"] = Convert.ToInt32(id);
                            return RedirectToAction("Index", "Student");
                        }
                        else{
                            TempData["msg"] = "<script>alert('Incorrect Username Or Password');</script>";
                            return RedirectToAction("Index");
                        }
                    }
                }
                else if (SelectType == "3")
                {
                    IEnumerable<Faculty> admin = Fservice.GetAll();
                    foreach (Faculty ad in admin)
                    {
                        if (ad.FacultyId == Convert.ToInt32(id) && ad.FacultyPass == password)
                        {
                            Session["id"] = Convert.ToInt32(id);
                            return RedirectToAction("Index", "Faculty", new { ad });
                        }
                        else
                        {
                            TempData["msg"] = "<script>alert('Incorrect Username Or Password');</script>";
                            return RedirectToAction("Index");
                        }
                    }
                }
                
                TempData["msg"] = "<script>alert('No match found');</script>";
                return RedirectToAction("Index");
            }
        }

    }
}
