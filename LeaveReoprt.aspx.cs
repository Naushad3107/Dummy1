using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leave_management
{
    public partial class LeaveReoprt : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;
            string getReport = $"exec getAll '{email}'";
            SqlCommand cmd = new SqlCommand(getReport, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            //GvLeaveReport.DataSource = sdr;
            //GvLeaveReport.DataBind();
            string report = "";
            if (dr.Read())
            {
                string empName = dr["eName"].ToString();
                string empId = dr["eId"].ToString();
                //string dept = dr["Department"].ToString();
                string desg = dr["eRole"].ToString();
                string leaveType = dr["leavetype"].ToString();
                string startDate = Convert.ToDateTime(dr["startDate"]).ToString("dd/MM/yyyy");
                string endDate = Convert.ToDateTime(dr["endDate"]).ToString("dd/MM/yyyy");
                //string duration = dr["Duration"].ToString();
                string leaveId = dr["leaveId"].ToString();

                string status = dr["status"].ToString();
                //string balance = dr["RemainingBalance"].ToString();
                //string reportDate = DateTime.Now.ToString("dd/MM/yyyy");

                report = $@"
<b>Employee Name:</b> {empName}<br/>
<b>Employee ID:</b> {empId}<br/>

<b>Designation:</b> {desg}<br/>
<b>Report Period:</b> {startDate} - {endDate}<br/><br/>

<h4>Leave Summary</h4>
<b>Leave Type:</b> {leaveType}<br/>
<b>Start Date:</b> {startDate}<br/>
<b>End Date:</b> {endDate}<br/>

";
            }

            conn.Close();
            //return report;
            Console.WriteLine(report);





        }
    }
}