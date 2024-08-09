using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KHUTO_39990966
{
    public partial class Default : System.Web.UI.Page
    {
        string zone;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbZone1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //implementation for storing the personal data

            HttpCookie userInformation = new HttpCookie("userInfo");
            userInformation["name"]=txtName.Text;
            userInformation["email"]=txtEmail.Text;
            userInformation["surname"]=txtSurname.Text;

            Response.Cookies.Add(userInformation);

            string zoneDescr = "";

            //storing the the region information
            if(rbZone1.Checked)//helps us easily identify the zone selected
            {
                zone = "1";//helps us easily identify the schedules
                zoneDescr = rbZone1.Text;//stores the exact text on the radio button
            }
            else if(rbZone2.Checked)
            {
                zone = "2";
                zoneDescr = rbZone2.Text;
            }
            else if (rbZone3.Checked)
            {
                zone = "3";
                zoneDescr = rbZone3.Text;
            }
            else if (rbZone4.Checked)
            {
                zone = "4";
                zoneDescr = rbZone4.Text;
            }
            else if (rbZone5.Checked)
            {
                zone = "5";
                zoneDescr = rbZone5.Text;
            }
            else if (rbZone6.Checked)
            {
                zone = "6";
                zoneDescr = rbZone6.Text;
            }
            Session["zone"]=zone;
            Session["zoneDescr"] = zoneDescr;

            Response.Redirect("Info.aspx");//go to the next page
        }
    }
}