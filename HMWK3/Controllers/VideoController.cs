using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using HMWK3.Models;

namespace HMWK3.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Index()
        {

            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Content/Media/Videos/"));

            List<FileModel> MyFiles = new List<FileModel>();

            foreach (string filePath in filePaths)
            {
                MyFiles.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            }
            return View(MyFiles);
        }


        public FileResult DownloadFile(string fileName)
        {

            string path = Server.MapPath("~/Content/Media/Videos/") + fileName;

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {
            string path = Server.MapPath("~/Content/Media/Videos/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }
    }
}
