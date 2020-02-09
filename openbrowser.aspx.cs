using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class openbrowser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Open default browser 
            System.Diagnostics.Process.Start("http://google.com");

        }
    }
}