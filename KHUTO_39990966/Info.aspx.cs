using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KHUTO_39990966
{
    public partial class Info : System.Web.UI.Page
    {
        String zone = "";
        string schedule="";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Today;//set the selecteed date to today's date
            }

            zone = Session["zone"].ToString();//retrieve the numeric value of the zone

            //retrieving user information
            HttpCookie retrieveCookie = Request.Cookies["userInfo"];
            if(retrieveCookie != null )
            {
                lblGreeting.Text = "Welcome " + retrieveCookie["name"] + " " + retrieveCookie["surname"] + "!";
            }
            else
            {
                lblGreeting.Text = "No such cookie found!";
            }
            //retrieving the zone selected
            if (Session["zone"]!=null&& Session["zoneDescr"]!=null)
            {

                lblZone.Text = "Your current zone is: " + Session["zoneDescr"].ToString();
            }

            showSchedule();//call the show schedule method
        }

        private void showSchedule()//so i can reuse the code
        {
            //clear the labels for convenience
            lblMessage.Text = "";
            lblSchedule.Text = "";
            lblMessage.ForeColor = Color.Black;
            if (zone == "1")
            {
                if (Calendar1.SelectedDate.DayOfWeek.ToString() == "Monday" || Calendar1.SelectedDate.DayOfWeek.ToString() == "Thursday")
                {
                    lblMessage.Text = "There is no Load schedding in your area today";
                    lblMessage.ForeColor = Color.Red;//to clearly show the message in red color
                }
                else
                {
                    lblMessage.Text = "Today's Loadshedding forecast:";
                    lblSchedule.Text = "06:00-8:30, 12:00-14:30";
                }
            }
            else if (zone == "2")
            {
                if (Calendar1.SelectedDate.DayOfWeek.ToString() == "Tuesday" || Calendar1.SelectedDate.DayOfWeek.ToString() == "Friday")
                {
                    lblMessage.Text = "There is no Load schedding in your area today";
                    lblMessage.ForeColor = Color.Red;//to clearly show the message in red color
                }
                else
                {
                    lblMessage.Text = "Today's Loadshedding forecast:";
                    lblSchedule.Text = "09:00-11:30, 15:00-17:30";
                }
            }
            else if (zone == "3")
            {
                if (Calendar1.SelectedDate.DayOfWeek.ToString() == "Wednesday" || Calendar1.SelectedDate.DayOfWeek.ToString() == "Saturday")
                {
                    lblMessage.Text = "There is no Load schedding in your area today";
                    lblMessage.ForeColor = Color.Red;//to clearly show the message in red color
                }
                else
                {
                    lblMessage.Text = "Today's Loadshedding forecast:";
                    lblSchedule.Text = "18:00-20:30, 00:00-02:30";
                }
            }
            else if (zone == "4")
            {
                if (Calendar1.SelectedDate.DayOfWeek.ToString() == "Sunday" || Calendar1.SelectedDate.DayOfWeek.ToString() == "Wednesday")
                {
                    lblMessage.Text = "There is no Load schedding in your area today";
                    lblMessage.ForeColor = Color.Red;//to clearly show the message in red color
                }
                else
                {
                    lblMessage.Text = "Today's Loadshedding forecast:";
                    lblSchedule.Text = "21:00-23:30, 03:00-05:30";
                }
            }
            else if (zone == "5")
            {
                if (Calendar1.SelectedDate.DayOfWeek.ToString() == "Monday" || Calendar1.SelectedDate.DayOfWeek.ToString() == "Saturday")
                {
                    lblMessage.Text = "There is no Load schedding in your area today";
                    lblMessage.ForeColor = Color.Red;//to clearly show the message in red color
                }
                else
                {
                    lblMessage.Text = "Today's Loadshedding forecast:";
                    lblSchedule.Text = "07:00-9:30, 13:00-15:30";
                }
            }
            else if (zone == "6")
            {
                if (Calendar1.SelectedDate.DayOfWeek.ToString() == "Thursday" || Calendar1.SelectedDate.DayOfWeek.ToString() == "Sunday")
                {
                    lblMessage.Text = "There is no Load schedding in your area today";
                    lblMessage.ForeColor = Color.Red;//to clearly show the message in red color
                }
                else
                {
                    lblMessage.Text = "Today's Loadshedding forecast:";
                    lblSchedule.Text = "10:00-12:30, 16:00-18:30";
                }
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            showSchedule();//call the show schedule method
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");//navigate back to registration
        }
    }
}