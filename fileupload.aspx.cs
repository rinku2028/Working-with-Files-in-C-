using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fileupload
{
    public partial class fileupload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            if (fileupload1.HasFile)
            {
                try
                {

                    fileupload1.SaveAs("E:\\" + fileupload1.FileName);

                    lblMessage.Text = "File uploaded succesfully in C:Drive";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "File not uploaded!!" + ex.Message.ToString();

                }

            }
            else
            {
                lblMessage.Text = "Please select the file and upload again!!!";
            }
        }
    }
}