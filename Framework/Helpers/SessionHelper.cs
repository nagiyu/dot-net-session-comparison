using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framework.Helpers
{
    public class SessionHelper
    {
        // セッションのカウンターを取得する
        public static JsonResult GetSessionCounter(HttpSessionStateBase session)
        {
            // セッションのカウンターを取得
            var counter = 0;
            if (session["Counter"] != null)
            {
                counter = (int)session["Counter"];
            }

            // JSON でカウンターを返す
            return new JsonResult { Data = new { counter = counter }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // セッションのカウンターをインクリメントする
        public static JsonResult IncrementSessionCounter(HttpSessionStateBase session)
        {
            // セッションのカウンターを取得
            var counter = 0;
            if (session["Counter"] != null)
            {
                counter = (int)session["Counter"];
            }

            // セッションのカウンターをインクリメント
            counter++;

            // セッションのカウンターを更新
            session["Counter"] = counter;

            // JSON でインクリメントしたカウンターを返す
            return new JsonResult { Data = new { counter = counter }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}