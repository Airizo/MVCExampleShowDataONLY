using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCExample.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(DisplayRecords dr)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection SqlCon = new SqlConnection(mainconn);
            string s1 = "select * from [ppsl].[Proposals]";
            SqlCommand sqlconn = new SqlCommand(s1);
            sqlconn.Connection = SqlCon;
            SqlCon.Open();
            SqlDataReader sdr = sqlconn.ExecuteReader();
            List<DisplayRecords> objmodel = new List<DisplayRecords>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    var details = new DisplayRecords();
                    details.Proposal_Uid = sdr["Proposal_Uid"].ToString();
                    details.Prime_Contract = sdr["Prime_Contract"].ToString();
                    details.Proposal_Title = sdr["Proposal_Title"].ToString();
                    details.Client_Name = sdr["Client_Name"].ToString();
                    details.Client_Code = sdr["Client_Code"].ToString();
                    details.Total_Proposal_Amount = sdr["Total_Proposal_Amount"].ToString();
                    details.Manager_name = sdr["Manager_name"].ToString();
                    details.Start_Date = sdr["Start_Date"].ToString();
                    details.End_Date = sdr["End_Date"].ToString();
                    details.Proposal_Number = sdr["Proposal_Number"].ToString();
                    details.Contract_Type = sdr["Contract_Type"].ToString();
                    objmodel.Add(details);
                }
                dr.UsersInfo = objmodel;
                SqlCon.Close();
            }
            return View("Index",dr);
        }
    }
}