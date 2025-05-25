using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestsDataAccess
    {



        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into Tests (TestAppointmentID,TestResult,Notes,CreatedByUserID)
                             VALUES (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);
                                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
                else
                    return -1;


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }




            return -1;
        }

        public static bool GetTestAppointmentInfoByID(int TestID,ref int TestAppointmentID,ref bool TestResult,ref string Notes,ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from Tests
                                    Where TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = (string)reader["Notes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
            }
            catch (Exception ex)
            {

            }
            finally

            {
                connection.Close();
            }

            return isFound;
        }

    }
}
