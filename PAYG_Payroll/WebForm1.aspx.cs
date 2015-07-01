using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PAYG_Payroll
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                DayPilotCalendar1.DataBind();
        }

        protected void DayPilotCalendar1_EventClick(object sender, DayPilot.Web.Ui.Events.EventClickEventArgs e)
        {
            Label1.Text = "Selected event: ";
        }
    }
}