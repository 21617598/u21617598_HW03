using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMWK3.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase mediafiles)   //HttpRequestBase: We can use HttpRequestBase class property named Request to get collection of files or single file.
        //HttpPostedFileBase: This is the easiest way to read the uploaded files into the controller 
        {
            if (mediafiles != null)
            {
                // extract only the filename

                var fileName = Path.GetFileName(mediafiles.FileName);
                var RadioButton = Request["radiobutton"];
                if (RadioButton == "Document")
                {
                    // var ServerSavePath = Path.Combine(Server.MapPath("~/App_Data/Media/Files/") + fileName);
                    var filepath = Path.Combine(Server.MapPath("~/Content/Media/Files/"), fileName);
                    //Save file to server folder
                    // file.SaveAs(ServerSavePath);
                    mediafiles.SaveAs(filepath);
                    //assigning file uploaded status to ViewBag for showing message to user.
                    ViewBag.UploadStatus = " files uploaded successfully.";
                }
                else if (RadioButton == "Image")
                {
                    // var ServerSavePath = Path.Combine(Server.MapPath("~/App_Data/Media/Files/") + fileName);
                    var filepath = Path.Combine(Server.MapPath("~/Content/Media/Images/"), fileName);
                    //Save file to server folder
                    // file.SaveAs(ServerSavePath);
                    mediafiles.SaveAs(filepath);
                    //assigning file uploaded status to ViewBag for showing message to user.
                    ViewBag.UploadStatus = " files uploaded successfully.";
                }
                else if (RadioButton == "Video")
                {
                    // var ServerSavePath = Path.Combine(Server.MapPath("~/App_Data/Media/Files/") + fileName);
                    var filepath = Path.Combine(Server.MapPath("~/Content/Media/Videos/"), fileName);
                    //Save file to server folder
                    // file.SaveAs(ServerSavePath);
                    mediafiles.SaveAs(filepath);
                    //assigning file uploaded status to ViewBag for showing message to user.
                    ViewBag.UploadStatus = " files uploaded successfully.";
                }

            }
            return RedirectToAction("Index");
        }

                public ActionResult About()
                {
                    return View();
                }
    }
}
    