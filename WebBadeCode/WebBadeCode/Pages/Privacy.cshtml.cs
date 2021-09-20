using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebBadeCode.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(this.Request.Query["ID"]))
            {
                //string queryString = "SELECT tPatCulIntPatIDPk, tPatSFirstname, tPatSName, tPatDBirthday  FROM  [dbo].[TPatientRaw] WHERE tPatSName = " + this.Request.Query["ID"].ToString();
                //string connectionString = "Server=.\\PDATA_SQLEXPRESS;Database=;User Id=sa;Password=2BeChanged!;";

                //// new feature

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                //    connection.Open();
                //    var reader = command.ExecuteReader();
                //    try
                //    {
                //        while (reader.Read())
                //        {
                            
                //        }
                //    }
                //    finally
                //    {
                //        // Always call Close when done reading.
                //        reader.Close();
                //    }
                //}
            }
        }
        }
    }