using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUsersDataAccess
    {
        
        public static int AddNewUser(int PersonID,string UserName,string Password,bool IsActive)
        {
            int UserId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Users PersonID = @PersonID , UserName= @UserName, Password= @Password, IsActive = @IsActive;
            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonId", PersonID);
            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("@IsActice", IsActive);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    UserId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return UserId;
        }

        public static bool GetUserInfoByID(int UserID,ref int PersonID,ref string FullName,ref string UserName,ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select U.UserId , U.PersonID, P.FirstName +' '+ P.SecondName + ' '+ P.ThirdName+' ' + P.LastName as FullName
                              ,U.UserName,U.IsActive from 
                               Users U Inner join People P on 
                                U.PersonID = P.PersonID Where U.UserID = @UserID";
            
           SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    PersonID= (int)reader["PersonID"]; 
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    FullName = (string)reader["FullName"];
                    IsActive = (bool)reader["IsActive"];
                }
            }
            catch(Exception ex)
            {

            }
            finally

            {
                connection.Close(); 
            } 

            return isFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();



            SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString);
            string query = @"Select U.UserId , U.PersonID, P.FirstName +' '+ P.SecondName + ' '+ P.ThirdName+' ' + P.LastName as FullName
                              ,U.UserName,U.IsActive from 
                               Users U Inner join People P on 
                                U.PersonID = P.PersonID"; 

                
            SqlCommand command = new SqlCommand(query,connection);  


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

        public static bool UpdateUserInfo(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {

            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Users PersonID = @PesonID, UserName= @UserName,Password=@Password,IsActive=@IsActive where UserID=@UserID";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("UserId", UserID);
            command.Parameters.AddWithValue("@PersonId", PersonID);
            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("@IsActice", IsActive);

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


            return (AffectedRows>0);
        }


        
    }











}
