using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDetainLicenseDataAccess
    {

        public static int DetainLicense(int LicenseID,DateTime DetainDate,decimal FineFees,int CreatedByUserID,bool IsReleased)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased)
                             VALUES (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);


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



        public static bool IsDetainLicense(int LicenseID)
        {
            int isDetainLicense = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select COUNT(1) from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0 ";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                isDetainLicense = (int)command.ExecuteScalar();

            }
            catch(Exception ex)
            {

            }
            
            finally
            {
                connection.Close() ;
            }


            return isDetainLicense >0;
        }


     
        public static bool ReleaseDetainedLicense(int DetainID, bool IsReleased,DateTime ReleaseDate ,int ReleasedByUserID, int ReleaseApplicationID)
        {

            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update DetainedLicenses SET IsReleased= @IsReleased,
                                                            ReleaseDate = @ReleaseDate,
                                                            ReleasedByUserID = @ReleasedByUserID,
                                                            ReleaseApplicationID = @ReleaseApplicationID

                                                            where DetainID=@DetainID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            { connection.Close(); }


            return (AffectedRows > 0);
        }


        public static bool GetDetainInfoByLicenseID(ref int DetainID ,int LicenseID,ref DateTime DetainDate,ref decimal FineFees,ref int CreatedByUserID,ref bool IsReleased)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased= 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

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

    }
}
