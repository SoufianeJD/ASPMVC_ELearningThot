using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearningProject_SoufianeJD.Models;

namespace ELearningProject_SoufianeJD.Controllers
{
    public class TeacherController : Controller
    {
        private ELearningLINQDataContext db = new ELearningLINQDataContext();
        private ChatBoardStudentsLinqDataContext db1 = new ChatBoardStudentsLinqDataContext();
        private bool connect = false;
        // GET: Teacher
        public ActionResult Logout()
        {

            Session["id"] = null;
            Session["type"] = null;
            Session["actif"] = null;
            Session["level"] = null;
            connect = false;
            Session.Abandon();

            return View("SignInTeacher");
        }
        public ActionResult Index()
        {

            var LaListeDesCours = (from el in db.cours

                                   select el).Take(3);

            try
            {
                if (Session["id"].ToString() != null)
                    ViewBag.user = Session["id"].ToString().Trim();
                ViewBag.image = "../profile/" + Session["id"].ToString().Trim() + ".jpg";

            }
            catch (Exception e)
            {
                ViewBag.user = "Visitor";
                ViewBag.image = "https://i.ebayimg.com/images/g/ukAAAOSwFnFV9B5M/s-l300.jpg";
            }

            return View(LaListeDesCours);
        }

        public ActionResult SignInTeacher()
        {

            try
            {
                if (Session["id"].ToString() != null)
                    return RedirectToAction("LaListeDesCours");
            }
            catch (Exception ex)
            {

            }

            return View();

        }

        [HttpPost]
        public ActionResult SignInTeacher(teacher e)
        {

            if (!ModelState.IsValidField("Id") || !ModelState.IsValidField("pw"))
                return View();

            try
            {
                teacher e1 = (from el in db.teachers
                              where el.Id == e.Id && el.pw == e.pw
                              select el).Single<teacher>();

                Session["id"] = e1.Id;
                Session["type"] = e1.img;
                Session["actif"] = e1.status;
            
                connect = true;
              
                    return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                if (ex is InvalidOperationException)
                    ModelState.AddModelError("pw", "UserName or/and Password Incorrect");
                else
                    ModelState.AddModelError("pw", "Something Went Wrong");

                return View();
            }
        }
        public ActionResult AddANEWClass()
        {
            try
            {
                if (Session["type"].ToString() == "teacher")
                    return View();
            }
            catch (Exception e)
            {
                return RedirectToAction("SignUpTeacher");
            }
            return RedirectToAction("SignUpTeacher");

        }

        [HttpPost]
        public ActionResult AddANEWClasss(cours c, HttpPostedFileBase file)
        {
            c.Owner = Session["id"].ToString().Trim();

            db.cours.InsertOnSubmit(c);
            db.SubmitChanges();

            var path = Path.Combine(Server.MapPath("~/CoursIMG"), c.Id + ".jpg");
            file.SaveAs(path);

            return RedirectToAction("LesCours");
        }
        public ActionResult LaListeDesCours()
        {

            try
            {
                if (Session["type"].ToString().Trim() == "teacher")
                {
                    var listecours = (from el in db.cours where el.Owner == Session["id"].ToString() select el);
                    foreach (cours e in listecours)
                    {
                        try
                        {
                            int l = (from el in db.inscriptionTs
                                     where el.cours == e.Id && el.teacher == Session["id"].ToString()
                                     select el.cours).Single<int>();
                            e.status = 1;

                        }
                        catch (System.InvalidOperationException ex)
                        {

                            e.status = 0;
                        }
                    }
                    ViewBag.listecours = listecours;

                }
                else
                {
                    var listecours = (from el in db.cours where el.Owner == Session["id"].ToString() select el);
                    ViewBag.listecours = listecours;
                }



                return View();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }


        }
     public ActionResult LesCours(int? id)
        {
            cours cours;
            IQueryable<comment> listecomments = null;
            try
            {
                if (Session["type"].ToString().Trim() == "student")
                {
                    (from el in db.inscriptions where el.cours == id && el.student == Session["id"].ToString() select el.cours).Single<int>();

                    cours = (from el in db.cours where el.Id == id select el).Single<cours>();

                    if (cours.Level == "1")
                        ViewBag.level = "Secondaire";
                    else if (cours.Level == "2")
                        ViewBag.level = "Collegial";
                    else
                        ViewBag.level = "Universitaire";

                    db.SubmitChanges();
                }
                else
                {
                    cours = (from el in db.cours where el.Id == id select el).Single<cours>();
                    if (cours.Level == "1")
                        ViewBag.level = "Secondaire";
                    else if (cours.Level == "2")
                        ViewBag.level = "Collegial";
                    else
                        ViewBag.level = "Universitaire";

                    db.SubmitChanges();
                }

            }

            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }

            try
            {

                listecomments = (from el in db.comments where el.cours == cours.Id orderby el.Id descending select el);
            }
            catch (System.InvalidOperationException ex)
            {
            }

            ViewBag.comments = listecomments;
            return View(cours);
        }
    }
}