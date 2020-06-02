using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewDemoProject.Models;

namespace NewDemoProject.Controllers
{
    public class trackController : Controller
    {
        // GET: treack
        public ActionResult trackstatus(int trackno)
        {
            status status = new status();
            string db = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(db))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("track_incident", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@incident_id", trackno);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(ds);
                List<status> statuslist = new List<status>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    status temp = new status();
                    temp.assignedto = ds.Tables[0].Rows[i]["handler_name"].ToString();
                    temp.currstatus = ds.Tables[0].Rows[i]["current status"].ToString();
                    statuslist.Add(temp);
                }

                status.statuses = statuslist;
                con.Close();

            }
            return View(status);


        }



        public ActionResult listtickets(string employeemailid)
        {
            incidentlist incidents = new incidentlist();
            string db = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(db))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("listincidents", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_mail_id", employeemailid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open(); da.Fill(ds);
                List<incidentlist> incidentlists = new List<incidentlist>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incidentlist incidentlist = new incidentlist();
                    incidentlist.incidentID = Convert.ToInt32(ds.Tables[0].Rows[i]["incident_id"]);
                    incidentlist.title = ds.Tables[0].Rows[i]["incident_title"].ToString();
                    incidentlists.Add(incidentlist);
                }
                incidents.incidentarray = incidentlists;
                return View(incidents);
            }

        }
    }
}