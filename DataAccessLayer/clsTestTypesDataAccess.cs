using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestTypesDataAccess
    {
        public static bool GetTestTypeByID(int ID, ref string Title,ref string Description, ref float Fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @ID";

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

                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees = reader["TestTypeFees"] != DBNull.Value
         ? (float)Convert.ToDecimal(reader["TestTypeFees"])
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

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string queru = @"Select * from TestTypes";
            SqlCommand command = new SqlCommand(queru, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
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

        public static bool UpdateTestType(int TestTypeID,  string Title, string Description, float Fees)
        {
            int AffectedRow = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update TestTypes set TestTypeTitle = @Title,TestTypeDescription=@Description, TestTypeFees= @Fees where TestTypeID =@TestTypeID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Description", Description);
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
