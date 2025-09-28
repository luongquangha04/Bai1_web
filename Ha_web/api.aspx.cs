using System;
using System.Text;
using System.Web;
using System.Web.UI;
using DLL;

namespace Ha_web
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Chỉ chấp nhận POST
            if (Request.HttpMethod != "POST")
            {
                Response.Clear();
                Response.StatusCode = 405;
                Response.ContentType = "application/json";
                Response.ContentEncoding = Encoding.UTF8;
                Response.Write("{\"error\":\"Chỉ hỗ trợ POST\"}");
                Response.Flush();
                HttpContext.Current.ApplicationInstance.CompleteRequest();
                return;
            }

            string name = Request.Form["name"];

            if (string.IsNullOrEmpty(name))
            {
                ReturnJsonError("Thiếu hoặc trống tham số name");
                return;
            }

            try
            {
                string proverb = Cham_Ngon.GetProverb(name.Trim()); // gọi DLL

                string safe = EscapeForJson(proverb);

                Response.Clear();
                Response.ContentType = "application/json";
                Response.ContentEncoding = Encoding.UTF8;
                Response.Write("{\"proverb\":\"" + safe + "\"}");
                Response.Flush();
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                ReturnJsonError("Lỗi server: " + ex.Message);
            }
        }

        private void ReturnJsonError(string msg)
        {
            Response.Clear();
            Response.ContentType = "application/json";
            Response.ContentEncoding = Encoding.UTF8;
            Response.Write("{\"error\":\"" + EscapeForJson(msg) + "\"}");
            Response.Flush();
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        // Escape string đơn giản cho JSON
        private string EscapeForJson(string s)
        {
            if (s == null) return "";
            return s
                .Replace("\\", "\\\\")
                .Replace("\"", "\\\"")
                .Replace("\r", "\\r")
                .Replace("\n", "\\n");
        }
    }
}
