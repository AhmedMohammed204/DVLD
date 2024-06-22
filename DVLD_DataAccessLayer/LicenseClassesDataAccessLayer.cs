using MyClassLibrary;
using PeopleDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LicenseClassesDataAccessLayer
{
    public static class clsLicenseClassesDataAccess
    {
        public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }

            return isFound;

        }
        
        public static bool GetLicenseClassInfoByClassName(ref int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }

            return isFound;

        }
        
        public static int AddNewLicenseClass(string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LicenseClasses VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ClassName", ClassName);

            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);

            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);

            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);

            command.Parameters.AddWithValue("@ClassFees", ClassFees);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine(Error:  + ex.Message);
                clsErrorHandling.HandleError(ex);
            }

            finally
            {
                connection.Close();
            }


            return ID;

        }
        public static bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LicenseClasses
	SET	ClassName = @ClassName,
	ClassDescription = @ClassDescription,
	MinimumAllowedAge = @MinimumAllowedAge,
	DefaultValidityLength = @DefaultValidityLength,
	ClassFees = @ClassFees	WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);

            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);

            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);

            command.Parameters.AddWithValue("@ClassFees", ClassFees);


            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsLicenseClassExist(int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM LicenseClasses WHERE LicenseClassID= @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }


            return isFound;

        }

        public static DataTable GetAllLicenseClasses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }


            return dt;
        }


    }

}