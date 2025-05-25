using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsTestAppointmentsDataAccess
    {


        public static int AddNewTestAppointment(int TestTypeID,int LocalDrivingLicenseApplicationID,DateTime AppointmentDate,decimal PaidFees,int CreatedByUserID,bool IsLocked)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)
                             VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked);
                                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
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

        public static bool UpdateTestAppointmentInfoint(int TestAppointmentID, DateTime AppointmentDate,decimal PaidFees,bool IsLocked)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update TestAppointments 
                                set AppointmentDate=@AppointmentDate,
                                    PaidFees=@PaidFees,
                                     IsLocked=@IsLocked
                        WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
        public static DataTable GetAllTestAppointmentsByLocalAppID(int LocalAppID,int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from  TestAppointments
                    where LocalDrivingLicenseApplicationID = @LocalAppID And TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
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



        public static bool GetTestAppointmentInfoByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from TestAppointments
                                    Where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
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



        public static int GetCountTestAppointmentByLcalAppIDAndTestTypeID(int LocalAppID, int TestTypeID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT Count(*)
                        FROM TestAppointments AS Ap INNER JOIN
                  Tests AS Te ON Ap.TestAppointmentID = Te.TestAppointmentID
                  where Ap.LocalDrivingLicenseApplicationID = @LocalAppID and Ap.TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
                else
                    return 0;


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }




            return 0;

        }


        public static bool CheckTestIsActive(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int Active = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select 1 from TestAppointments
                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and IsLocked = 0 and TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID > 0;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }




            return false;



        }


    }

}
