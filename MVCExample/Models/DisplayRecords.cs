using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class DisplayRecords
    {
        
        public string Proposal_Uid { get; set; }
        public string Prime_Contract { get; set; }
        public string Proposal_Title { get; set; }
        public string Client_Name { get; set; }
        public string Client_Code { get; set; }
        public string Total_Proposal_Amount { get; set; }
        public string Manager_name { get; set; }
        public string Start_Date { get; set; }
        public string End_Date {  get; set; }
        public string Proposal_Number { get; set; }
        public string Contract_Type { get; set; }

        public List<DisplayRecords> UsersInfo { get; set; }

    }
}
