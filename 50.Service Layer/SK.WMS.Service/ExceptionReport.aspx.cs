using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Diagnostics;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class ExceptionReport : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
        //query string으로 값으로 userid 정보가 전달됨.
		string userID = Request["userid"];

		StreamReader reader = new StreamReader(Request.InputStream, System.Text.Encoding.ASCII);
		string exceptionTime = reader.ReadLine();
		string encoded = reader.ReadLine();

		byte[] data = Convert.FromBase64String(encoded);
		string message = System.Text.Encoding.Unicode.GetString(data);

		string logMsg = string.Format("[{0}]\t{1}\t{2}", exceptionTime, userID, message);
        //LogWrapper.Write(logMsg, "Exception", TraceEventType.Error);
	}
}
