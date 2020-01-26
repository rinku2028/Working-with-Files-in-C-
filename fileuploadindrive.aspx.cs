using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fileupload
{
    public partial class fileuploadindrive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            string savePath = @"c:\temp\uploads\";
            if (FileUpload1.HasFile)
            {
                int fileSize = upload1.PostedFile.ContentLength;
                if (fileSize < 2100000)
                {
                    savePath += Server.HtmlEncode(upload1.FileName);
                    upload1.SaveAs(savePath);
                    lblMessage.Text = "File was uploaded successfully!!!";



                }
                else
                {
                    lblMessage.Text = "File was not uploaded because " + "file exceeds the 2 MB size limit.";


                }
                lblMessage.Text = "Please specify to upload file!!!";


            }

        }
    }
}