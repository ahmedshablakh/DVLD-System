using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDataAccessLayer
{
    public class clsAppTypeDataAccess
    {

        public static bool GetApplicationTypeByID(int ID,ref string Title, ref float Fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = reader["ApplicationFees"] != DBNull.Value
         ? (float)Convert.ToDecimal(reader["ApplicationFees"])
         : 0f;

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllAppType()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string queru = @"Select * from ApplicationTypes";
            SqlCommand command = new SqlCommand(queru, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader !=null)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            { 
                connection.Close();
            }
            return dt;

        }

        public static bool UpdateAppType(int ApplicationTypeID, string Title,float Fees) 
        {
            int AffectedRow = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update ApplicationTypes set ApplicationTypeTitle = @Title, ApplicationFees= @Fees where ApplicationTypeID =@ApplicationTypeID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Fees", Fees);



            try
            {
                connection.Open();
                AffectedRow = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }

            return (AffectedRow > 0);
        }

    }
}
