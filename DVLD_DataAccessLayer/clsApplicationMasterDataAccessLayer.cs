using MyClassLibrary;
using PeopleDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ApplicationMaster_ViewDataAccessLayer
{
    public static class clsApplicationMaster_ViewDataAccess
    {
        public static bool GetApplicationMasterInfoByID(int ApplicationID, ref int ApplicantPersonID, ref byte ApplicationStatus, ref string ApplicationTypeTitle, ref decimal ApplicationFees, ref string FullName, ref DateTime ApplicationDate, ref DateTime LastStatusDate, ref string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationMaster_View WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicationID = reader["ApplicationID"] != DBNull.Value ? (int)reader["ApplicationID"] : ApplicationID = default;
                    ApplicantPersonID = reader["ApplicantPersonID"] != DBNull.Value ? (int)reader["ApplicantPersonID"] : ApplicantPersonID = default;
                    ApplicationStatus = reader["ApplicationStatus"] != DBNull.Value ? (byte)reader["ApplicationStatus"] : ApplicationStatus = default;
                    ApplicationTypeTitle = reader["ApplicationTypeTitle"] != DBNull.Value ? (string)reader["ApplicationTypeTitle"] : ApplicationTypeTitle = default;
                    ApplicationFees = reader["ApplicationFees"] != DBNull.Value ? (decimal)reader["ApplicationFees"] : ApplicationFees = default;
                    FullName = reader["FullName"] != DBNull.Value ? (string)reader["FullName"] : FullName = default;
                    ApplicationDate = reader["ApplicationDate"] != DBNull.Value ? (DateTime)reader["ApplicationDate"] : ApplicationDate = default;
                    LastStatusDate = reader["LastStatusDate"] != DBNull.Value ? (DateTime)reader["LastStatusDate"] : LastStatusDate = default;
                    UserName = reader["UserName"] != DBNull.Value ? (string)reader["UserName"] : UserName = default;

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
        public static int AddNewApplicationMaster(int ApplicantPersonID, byte ApplicationStatus, string ApplicationTypeTitle, decimal ApplicationFees, string FullName, DateTime ApplicationDate, DateTime LastStatusDate, string UserName)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO ApplicationMaster_View VALUES (@ApplicantPersonID, @ApplicationStatus, @ApplicationTypeTitle, @ApplicationFees, @FullName, @ApplicationDate, @LastStatusDate, @UserName)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            if (string.IsNullOrEmpty(ApplicantPersonID.ToString()))
                command.Parameters.AddWithValue("@ApplicantPersonID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            if (string.IsNullOrEmpty(ApplicationStatus.ToString()))
                command.Parameters.AddWithValue("@ApplicationStatus", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            if (string.IsNullOrEmpty(ApplicationTypeTitle))
                command.Parameters.AddWithValue("@ApplicationTypeTitle", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            if (string.IsNullOrEmpty(ApplicationFees.ToString()))
                command.Parameters.AddWithValue("@ApplicationFees", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            if (string.IsNullOrEmpty(FullName))
                command.Parameters.AddWithValue("@FullName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@FullName", FullName);
            if (string.IsNullOrEmpty(ApplicationDate.ToString()))
                command.Parameters.AddWithValue("@ApplicationDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            if (string.IsNullOrEmpty(LastStatusDate.ToString()))
                command.Parameters.AddWithValue("@LastStatusDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            if (string.IsNullOrEmpty(UserName))
                command.Parameters.AddWithValue("@UserName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@UserName", UserName);

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
        public static bool UpdateApplicationMaster(int ApplicationID, int ApplicantPersonID, byte ApplicationStatus, string ApplicationTypeTitle, decimal ApplicationFees, string FullName, DateTime ApplicationDate, DateTime LastStatusDate, string UserName)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationMaster_View
	SET	ApplicantPersonID = @ApplicantPersonID,
	ApplicationStatus = @ApplicationStatus,
	ApplicationTypeTitle = @ApplicationTypeTitle,
	ApplicationFees = @ApplicationFees,
	FullName = @FullName,
	ApplicationDate = @ApplicationDate,
	LastStatusDate = @LastStatusDate,
	UserName = @UserName	WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);


            if (string.IsNullOrEmpty(ApplicationID.ToString()))
                command.Parameters.AddWithValue("@ApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            if (string.IsNullOrEmpty(ApplicantPersonID.ToString()))
                command.Parameters.AddWithValue("@ApplicantPersonID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            if (string.IsNullOrEmpty(ApplicationStatus.ToString()))
                command.Parameters.AddWithValue("@ApplicationStatus", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            if (string.IsNullOrEmpty(ApplicationTypeTitle))
                command.Parameters.AddWithValue("@ApplicationTypeTitle", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            if (string.IsNullOrEmpty(ApplicationFees.ToString()))
                command.Parameters.AddWithValue("@ApplicationFees", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            if (string.IsNullOrEmpty(FullName))
                command.Parameters.AddWithValue("@FullName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@FullName", FullName);
            if (string.IsNullOrEmpty(ApplicationDate.ToString()))
                command.Parameters.AddWithValue("@ApplicationDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            if (string.IsNullOrEmpty(LastStatusDate.ToString()))
                command.Parameters.AddWithValue("@LastStatusDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            if (string.IsNullOrEmpty(UserName))
                command.Parameters.AddWithValue("@UserName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@UserName", UserName);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteApplicationMaster(int ApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE ApplicationMaster_View WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            if (string.IsNullOrEmpty(ApplicationID.ToString()))
                command.Parameters.AddWithValue("@ApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsApplicationMasterExist(int ApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM ApplicationMaster_View WHERE ApplicationID= @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            if (string.IsNullOrEmpty(ApplicationID.ToString()))
                command.Parameters.AddWithValue("@ApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

        public static DataTable GetAllApplicationMaster_View()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationMaster_View";
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