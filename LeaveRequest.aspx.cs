using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leave_management
{
    public partial class LeaveRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        {
           //string leavetype = TextBox1.Text;

            //DateTime selectedDate = DateTime.Parse(.SelectedValue);
            //string formattedDate = selectedDate.ToString("yyyy-MM-dd");


            SendMail();

            Response.Write("<script>alert('leave applied Successfully')</script>");


        }

        //public void SendMail(string ToEmail, string Sub, string body)
        public void SendMail()
        {
            {
                try
                {
                    MailMessage mail = new MailMessage();
                   
                    string from = TextBox4.Text;
                    mail.From = new MailAddress(from);
                   
                    mail.To.Add("rrai07505@gmail.com");//hr
                    mail.Bcc.Add("nikitalohar998@gmail.com");//manager
                    mail.Body = $"Leave Type: {TextBox1.Text}\nStart Date: {TextBox2.Text}\nEnd Date: {TextBox3.Text}";

                    
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    {
                        smtp.Port = 587;
                        smtp.Credentials = new NetworkCredential("nikitalohar503@gmail.com", "jduqgzycdsqqhbuf");
                        smtp.EnableSsl = true;
                            };
                    smtp.Send(mail);
                        Response.Write("<script>alert('Leave applied successfully');</script>");



                }
                catch (Exception ex) {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");

                }

            }
        }

       
    }
}