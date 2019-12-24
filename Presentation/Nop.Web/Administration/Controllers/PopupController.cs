
using Nop.Services.Media;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nop.Admin.Extensions;
using Nop.Services.Common;
using Nop.Core.Domain.Common;
using Nop.Admin.Models.Common;
using Nop.Web.Framework.Kendoui;
using Nop.Services.Security;

namespace Nop.Admin.Controllers
{
    public partial class PopupController : BaseAdminController
    {
        #region Fields

        private readonly IPopupService _popuprService;
        private readonly IPictureService _pictureService;
        private readonly IPermissionService _permissionService;


        #endregion

        #region Constructors

        public PopupController(IPopupService popuprService,
                      IPictureService pictureService,
                           IPermissionService permissionService

         )
        {
            this._popuprService = popuprService;
            this._pictureService = pictureService;
            this._permissionService = permissionService;

        }

        #endregion

      
        public ActionResult Index()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult List(DataSourceRequest command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManagePopup))
                return AccessDeniedView();

            var popup = _popuprService.GetAll( command.Page - 1, command.PageSize, true);
            var gridModel = new DataSourceResult
            {
                Data = popup.Select(x =>
                {
                    var m = x.ToModel();
                    //little hack here:
                    //ensure that descriptions are not returned
                    //otherwise, we can get the following error if entities have too long descriptions:
                    //"Error during serialization or deserialization using the JSON JavaScriptSerializer. The length of the string exceeds the value set on the maxJsonLength property. "
                    //also it improves performance
                 
                    return m;
                }),
                Total = popup.TotalCount
            };

            return Json(gridModel);
        }
        public ActionResult Edit(int id)
        {
            var entity = _popuprService.GetById(id);
            var model = entity.ToModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(PopupModel panner)
        {
            var model = panner.ToEntity();
            var popup = _popuprService.GetById(panner.Id);
            _popuprService.Edit(popup);
            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Insert(PopupModel panner)
        {
            var model = panner.ToEntity();
            _popuprService.Insert(model);
            return RedirectToAction("Index");
        }
    }
}