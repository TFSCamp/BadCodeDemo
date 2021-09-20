using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

            Console.WriteLine("test");
            
        }

        public static string GetMD5Hash(string TextToHash)
        {
            //Prüfen ob Daten übergeben wurden.
            if ((TextToHash == null) || (TextToHash.Length == 0))
            {
                return string.Empty;
            }

            //MD5 Hash aus dem String berechnen. Dazu muss der string in ein Byte[]
            //zerlegt werden. Danach muss das Resultat wieder zurück in ein string.
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);

            return System.BitConverter.ToString(result);
        }
    }
}