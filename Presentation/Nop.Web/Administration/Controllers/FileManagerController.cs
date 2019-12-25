using Nop.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nop.Admin.Controllers
{
    public class FileManagerController : BaseAdminController
    {
        // GET: FileManager
        public virtual ActionResult Index(string subFolder)
        {
            FileViewModel model = new FileViewModel { Folder = "DefaultClean", SubFolder = subFolder };
            return View(model);
        }
    }
}