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


        /*
        public static bool UpdateLicensInfo(int LicensID, bool IsActive)
        {

            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Licenses SET IsActive= @IsActive where LicenseID=@LicensID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicensID", LicensID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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


        public
        */

    }
}
