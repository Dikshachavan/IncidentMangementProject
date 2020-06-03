using NewDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;


namespace NewDemoProject.Controllers
{
    public class trackController : Controller
    {
        public static string mainConn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(mainConn);
        status status = new status();
        // GET: treack
        public ActionResult trackstatus(int trackno)
        {
            try
            {
                SqlCommand command = new SqlCommand("track_incident", connection);
                DataSet ds = new DataSet();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@incident_id", trackno);
                SqlDataAdapter da = new SqlDataAdapter(command);
                connection.Open();
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

                return View(status);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

        }


        public ActionResult listtickets(string Email_ID)
        {
            try
            {
                incidentlist incidents = new incidentlist();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("listincidents", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_mail_id", Email_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                connection.Open(); da.Fill(ds);
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
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                connection.Close();
            }
        }


        
        public ActionResult OnSubmit(int incidentid)
        {
            incidentlist incidents = new incidentlist();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("list_incident_onsubmit", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@incident_id", incidentid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open(); da.Fill(ds);
            List<incidentlist> incidentlists = new List<incidentlist>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                incidentlist incidentlist = new incidentlist();
                incidentlist.incidentID = Convert.ToInt32(ds.Tables[0].Rows[i]["incident_id"]);
                incidentlist.title = ds.Tables[0].Rows[i]["incident_title"].ToString();
                incidentlist.incident_description = ds.Tables[0].Rows[i]["incident_descripton"].ToString();
                incidentlist.raised_by = ds.Tables[0].Rows[i]["raised_by"].ToString();
                
                incidentlist.created_on = Convert.ToDateTime(ds.Tables[0].Rows[i]["created_on"]);
                
                    incidentlist.altered_on = Convert.ToDateTime(ds.Tables[0].Rows[i]["altered_on"]);
                incidentlists.Add(incidentlist);
            }
            incidents.incidentarray = incidentlists;
            return View(incidents);

            
        }




    }




}

