using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Fatura_Kayıt_Sistemi
{

   public class Connect_DB
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand command = new SqlCommand();
        private static string DecryptToBase64(string text)
        { 
            byte[] DecryptAsBytes = System.Convert.FromBase64String(text);

            string value = System.Text.ASCIIEncoding.ASCII.GetString(DecryptAsBytes);

            return value;

        }

        public Connect_DB()
        {
               string server_Adress;
               string server_pass;
               string ServerPort;
               string server_username;
               string databaseName;
            try
            {
                Save_INI INI = new Save_INI();
                string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(filePath, "Kayıt Otomasyonu");
                Directory.CreateDirectory(specificFolder);
                specificFolder = specificFolder + @"\ayarlar_beta.ini";
                INI.Path = specificFolder;
                server_Adress = INI.Read("veritabanı", "adres");
                ServerPort = INI.Read("veritabanı", "port");
                server_username = INI.Read("veritabanı", "kullanıcı_adı");
                server_pass = DecryptToBase64(INI.Read("veritabanı", "sifre"));
                databaseName = INI.Read("veritabanı", "isim");
                con.ConnectionString = string.Format("Data Source={0},{1}; User ID={2}; Password={3}; Initial Catalog={4};", server_Adress, ServerPort, server_username, server_pass, databaseName);
                command.Connection = con;
            }
            catch
            {
                throw;
            }
        }
       
        public static bool sendQuery( String query, List<SqlParameter> paramList)
        {
            bool result = false;
            try
            {

                command.CommandText = query;
                command.Parameters.AddRange(paramList.ToArray());
                con.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch 
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                con.Close();
            }
            return result;

        }

        public static bool sendQuery(String query)
        {
            bool result = false;
            try
            {

                command.CommandText = query;
                con.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch 
            {
                throw;
            }

            finally
            {
                con.Close();
                command.Parameters.Clear();
            }
            return result;

        }

        public static DataTable getQuery (String query, List<SqlParameter> paramList)
        {
            DataTable result = new DataTable();
            try
            {

                command.CommandText = query;
                command.Parameters.AddRange(paramList.ToArray());
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(result);
            }
            catch 
            {
                throw;
            }

            finally
            {
                con.Close();
                command.Parameters.Clear();
            }
            return result;
        }

        public static DataTable getQuery(String query)
        {
            DataTable result = new DataTable();
            try
            {
                    command.CommandText = query;
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(result);
            }
            catch 
            {
                throw;
            }

            finally
            {
                con.Close();
                command.Parameters.Clear();
            }
            return result;
        }

        public static Image getImage (String query)
        {
            Image result = null;
            try
            {
                command.CommandText = query;
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    byte[] data =  (byte[]) dr[0];
                    MemoryStream ms = new MemoryStream(data, 0, data.Length);
                    result = Image.FromStream(ms, true);
                }
                

            }
            catch 
            {
                throw;
            }
            finally
            {
                con.Close();
                command.Parameters.Clear();
            }
            return result;
        }

        public static Image getImage(String query, List<SqlParameter> paramList)
        {
            Image result = null;
            try
            {
                command.CommandText = query;
                command.Parameters.AddRange(paramList.ToArray());
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() && dr[0] != DBNull.Value)
                {
                    byte[] data = (byte[]) dr[0];
                    MemoryStream ms = new MemoryStream(data, 0, data.Length);
                    result = Image.FromStream(ms, true);
                }


            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
                command.Parameters.Clear();
            }
            return result;
        }
    }
}
