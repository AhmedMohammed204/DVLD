using MyClassLibrary;
using PeopleDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LocalDrivingLicenseApplications_ViewDataAccessLayer
{
    public static class clsLocalDrivingLicenseApplications_ViewDataAccess
    {
        public static bool GetLocalDrivingLicenseApplicationViewInfoByID(int LocalDrivingLicenseApplicationID, ref string ClassName, ref string NationalNo, ref string FullName, ref DateTime ApplicationDate, ref int PassedTestCount, ref string Status)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    ClassName = (string)reader["ClassName"];
                    NationalNo = (string)reader["NationalNo"];
                    FullName = (string)reader["FullName"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    PassedTestCount = (int)reader["PassedTestCount"];
                    Status = (string)reader["Status"];

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
        public static int AddNewLocalDrivingLicenseApplicationView(string ClassName, string NationalNo, string FullName, DateTime ApplicationDate, int PassedTestCount, string Status)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications_View VALUES (@ClassName, @NationalNo, @FullName, @ApplicationDate, @PassedTestCount, @Status)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ClassName", ClassName);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            command.Parameters.AddWithValue("@FullName", FullName);

            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);

            command.Parameters.AddWithValue("@PassedTestCount", PassedTestCount);

            command.Parameters.AddWithValue("@Status", Status);


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
        public static bool UpdateLocalDrivingLicenseApplicationView(int LocalDrivingLicenseApplicationID, string ClassName, string NationalNo, string FullName, DateTime ApplicationDate, int PassedTestCount, string Status)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseApplications_View
	SET	ClassName = @ClassName,
	NationalNo = @NationalNo,
	FullName = @FullName,
	ApplicationDate = @ApplicationDate,
	PassedTestCount = @PassedTestCount,
	Status = @Status	WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            command.Parameters.AddWithValue("@FullName", FullName);

            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);

            command.Parameters.AddWithValue("@PassedTestCount", PassedTestCount);

            command.Parameters.AddWithValue("@Status", Status);


            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteLocalDrivingLicenseApplicationView(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsLocalDrivingLicenseApplicationViewExist(int LocalDrivingLicenseApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        public static DataTable GetAllLocalDrivingLicenseApplications_View()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications_View";
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