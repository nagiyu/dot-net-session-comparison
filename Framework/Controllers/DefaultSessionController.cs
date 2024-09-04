using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Framework.Helpers;

namespace Framework.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Default)]
    public class DefaultSessionController : Controller
    {
        // セッションのカウンターを取得する
        public JsonResult GetSessionCounter()
        {
            return SessionHelper.GetSessionCounter(Session);
        }

        // セッションのカウンターをインクリメントする
        public JsonResult IncrementSessionCounter()
        {
            return SessionHelper.IncrementSessionCounter(Session);
        }
    }
}