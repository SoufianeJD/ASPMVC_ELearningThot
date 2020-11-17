using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using ELearningProject_SoufianeJD.Models;
using Microsoft.Ajax.Utilities;

namespace ELearningProject_SoufianeJD.Controllers
{
    public class StudentController : Controller
    {
        private ELearningLINQDataContext db = new ELearningLINQDataContext();

        private ChatBoardStudentsLinqDataContext db1 = new ChatBoardStudentsLinqDataContext();
        private bool connect = false;
        // GET: Student
        public ActionResult Logout()
        {
            Session["id"] = null;
            Session["type"] = null;
            Session["actif"] = null;
            Session["level"] = null;
            connect = false;
            Session.Abandon();


            return View("SignIn");
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
        public ActionResult SignIn()
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
        public ActionResult SignIn(student e)
        {


            if (!ModelState.IsValidField("Id") || !ModelState.IsValidField("pw"))
                return View();

            try
            {
                student e1 = (from el in db.students
                               where el.Id == e.Id && el.pw == e.pw
                               select el).Single<student>();

                Session["id"] = e1.Id;
                Session["type"] = e1.img;
                Session["actif"] = e1.status;
                Session["level"] = e1.level;
                connect = true;
                if (e1.status == 0)
                    return View("StudentActivation");
                else
                    return RedirectToAction("Index");
            }
            catch (Exception ex)
            {


                if (ex is InvalidOperationException)
                    ModelState.AddModelError("pw", "You're infos are incorrect, plz try again...");
                else
                    ModelState.AddModelError("pw", "Something Went Wrong, plz try again... ");

                return View();
            }
        }

        public ActionResult SignUp()
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
        public ActionResult SignUp(student e)
        {

            if (!ModelState.IsValid)
                return View();

            e.status = 0;
            e.img = "student";

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringCharsuser = new char[6];
            var stringCharspass = new char[8];
            var random = new Random();

            for (int i = 0; i < stringCharsuser.Length; i++)
            {
                stringCharsuser[i] = chars[random.Next(chars.Length)];
            }
            for (int i = 0; i < stringCharspass.Length; i++)
            {
                stringCharspass[i] = chars[random.Next(chars.Length)];
            }

          
            e.Id = new String(stringCharsuser);
            e.pw = new String(stringCharspass);
          
            db.students.InsertOnSubmit(e);
            db.SubmitChanges();
            string a = SendingMail.sendMail(new SendingMail { To = e.email, Subject = "Here your first time login activation ! ", Message = "Temporary username: " + e.Id + "\n Temporary password" + e.pw });
            ViewBag.msn = a;


            ViewBag.accept = "Registered successfully ! We sent an E-Mail for ur activation infos...";
            return View();

        }


        public ActionResult StudentActivation()
        {


            try
            {
                if (Session["actif"].ToString() == "1")
                    return RedirectToAction("LaListeDesCours");
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }


            return View();
        }

        [HttpPost]
        public ActionResult StudentActivation(student e)
        {

            if (!ModelState.IsValidField("Id") || !ModelState.IsValidField("pw"))
                return View();


            try
            {
                student e1 = (from el in db.students
                               where el.Id == Session["id"].ToString()
                               select el).Single<student>();

                e.status = 1;
                e.level = e1.level;
                e.name = e1.name;
                e.lastname = e1.lastname;
                e.img = "student";
                e.email = e1.email;

                db.students.InsertOnSubmit(e);

                db.students.DeleteOnSubmit(e1);
                db.SubmitChanges();

                Session["id"] = e1.Id;
                Session["type"] = "student";
                Session["actif"] = e1.status;
                Session["level"] = e1.level;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Id", "Alrady Exists");
                return View();
            }


            return Logout();
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

      
        public ActionResult LaListeDesCours()
        {

            try
            {
                if (Session["type"].ToString().Trim() == "student")
                {
                    var listecours = (from el in db.cours where el.Level == Session["level"].ToString() select el);
                    foreach (cours e in listecours)
                    {
                        try
                        {
                            int l = (from el in db.inscriptions
                                     where el.cours == e.Id && el.student == Session["id"].ToString()
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

        [HttpPost]
        public JsonResult inscrire()
        {

            inscription i = new inscription();

            i.cours = int.Parse(Request["cours"].ToString());
            i.student = Request["pw"].ToString();

            try
            {
                student e1 = (from el in db.students
                              where el.Id == Session["id"].ToString() && el.pw == i.student
                              select el).Single<student>();

                cours cc = (from el in db.cours where el.Id == i.cours select el).Single<cours>();

                inscription validatesubs = new inscription();
                validatesubs.cours = i.cours;
                validatesubs.student = Session["id"].ToString();

                db.inscriptions.InsertOnSubmit(validatesubs);
                db.SubmitChanges();

            }
            catch (System.InvalidOperationException ex)
            {
                return Json("false", JsonRequestBehavior.AllowGet);

            }
            return Json("true", JsonRequestBehavior.AllowGet);
        }

    }
}