using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryManagment_Data
{
    public class clsAdminData
    {
        public static bool GetAdminInfoByAdminID(int? AdminID, ref string Name, ref string Username, ref string PasswordHash, ref string Role)
        {
            bool IsFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = "SELECT * FROM Admins WHERE AdminID = @AdminID;";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", AdminID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    Name = (string)reader["Name"];
                    Username = (string)reader["Username"];
                    PasswordHash = (string)reader["PasswordHash"];
                    Role = (string)reader["Role"];
                    

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetAdminInfoByUsernameAndPassword(string Username,string Password,ref int AdminID,ref string Name,ref string Role)
        {
            bool IsFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = "SELECT * FROM Admins WHERE Username = @Username and PasswordHash = @Password;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        using(SqlDataReader reader = command.ExecuteReader()) 
                        {
                            if(reader.Read())
                            {
                                IsFound = true;
                                AdminID = (int)reader["AdminID"];
                                Name = (string)reader["Name"];
                                Role = (string)reader["Role"];
                            }
                        }
                    }

                    
                    
                }

                

            }
            catch
            {
                IsFound = false;
               
            }
            return IsFound;
        }
        public static int? AddNewAdmin(string Name,string Username,string PasswordHash,string Role)
        {
            int? AdminID = null;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = @"INSERT INTO Admins (Name,Username,PasswordHash,Role)
                           VALUES (@Name,@Username,@PasswordHash,@Role);
                           SELECT SCOPE_IDENTITY(); ";
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString) )
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                        command.Parameters.AddWithValue("@Role", Role);

                        object result = command.ExecuteScalar();
                        if(result != null && int.TryParse(result.ToString(),out int insertedID))
                        {
                            AdminID = insertedID;
                        }
                    }
                }
            }
            catch
            {
                AdminID = null;
            }
            return AdminID;
        }

        public static bool UpdateAdmin(int? AdminID,string Name, string Username,string PasswordHash,string Role)
        {
            int rowsAffected = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = @"UPDATE Admins
                            Set Name         = @Name,
                                Username     = @Username,
                                PasswordHash = @PasswordHash,
                                Role         = @Role
                               WHERE AdminID = @AdminID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@AdminID", AdminID);

                    try
                    {
                       rowsAffected =  command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;
                    }
                    return (rowsAffected > 0);

                }
            }
        }
        public static DataTable GetAllAdmins()
        {
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = "SELECT AdminID,Name,Username,Role FROM Admins;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {
                
            }
            return dt;
        }
        public static bool DeleteAdmin(int AdminID)
        {
            int rowsAffected = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = "DELETE Admins WHERE AdminID = @AdminID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminID", AdminID);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch
            {
                return false;
            }
            return (rowsAffected > 0);
            
        }

        public static bool IsAdminExist(int AdminID)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = "SELECT FOUND = 1 FROM Admins WHERE AdminID = @AdminID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminID", AdminID);

                        object result = command.ExecuteScalar();
                        isFound = (result != null);
                    }
                }
            }
            catch
            {
                isFound = false;
            }
            return isFound;
        }
        public static bool IsAdminExist(string Username)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = "SELECT FOUND = 1 FROM Admins WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);

                        object result = command.ExecuteScalar();
                        isFound = (result != null);
                    }
                }
            }
            catch
            {
                isFound = false;
            }
            return isFound;
        }
        public static bool ChangePassword(int AdminID, string NewPassword)
        {

            int rowsAffected = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

            string query = @"Update  Admins  
                            set PasswordHash = @Password
                            where AdminID = @AdminID";


            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@AdminID", AdminID);
                        rowsAffected = command.ExecuteNonQuery();
                    }

                }
                
                

            }
            catch
            {
                
                return false;
            }

            return (rowsAffected > 0);
        }
    }
}
