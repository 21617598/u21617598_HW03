using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace HMWK3.Models
{
    public class FileModel
    {

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] Files { get; set; }
    
    }
}