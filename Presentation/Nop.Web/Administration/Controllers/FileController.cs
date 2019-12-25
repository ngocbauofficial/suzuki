using System.IO;
using System.Web.Mvc;
using ElFinder;
using System.Collections.Generic;

using System.Web.Configuration;

namespace Nop.Admin.Controllers
{
    public class FileController : BaseAdminController
    {
        public virtual ActionResult Index(string folder, string subFolder)
        {
            string getpath = WebConfigurationManager.AppSettings["DirectoryElFinder"];
            var driver = new FileSystemDriver();

            var root = new Root(new DirectoryInfo(Server.MapPath("~/Themes/" + folder)),
                "http://" + Request.Url.Authority + "/Themes/" + folder + "/")
            {
                IsReadOnly = false,
                Alias = "Root",
                MaxUploadSizeInMb = 500,
                LockedFolders = new List<string>()
            };

            if (!string.IsNullOrEmpty(subFolder))
            {
                root.StartPath = new DirectoryInfo(Server.MapPath("~/Themes/" + folder + "/" + subFolder));
            }

            driver.AddRoot(root);
            var connector = new Connector(driver);
            return connector.Process(HttpContext.Request);
        }

        public virtual ActionResult SelectFile(string target)
        {
            var driver = new FileSystemDriver();

            driver.AddRoot(
                new Root(
                    new DirectoryInfo(Server.MapPath("~/Themes")),
                    "http://" + Request.Url.Authority + "/Themes")
                { IsReadOnly = false });

            var connector = new Connector(driver);

            return Json(connector.GetFileByHash(target).FullName);
        }

    }
}