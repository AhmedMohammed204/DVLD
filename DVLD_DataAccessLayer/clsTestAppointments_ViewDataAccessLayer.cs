using PeopleDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace TestAppointments_ViewDataAccessLayer
{
public static class clsTestAppointments_ViewDataAccess
{
public static bool GetTestAppointments_ViewInfoByID(int TestAppointmentID, ref int LocalDrivingLicenseApplicationID, ref string TestTypeTitle, ref string ClassName, ref DateTime AppointmentDate, ref decimal PaidFees, ref string FullName, ref bool IsLocked)
{
	bool isFound = false;

	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM TestAppointments_View WHERE TestAppointmentID = @TestAppointmentID";
	SqlCommand command = new SqlCommand(query, connection);
	command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

	try
	{

		connection.Open();
		SqlDataReader reader = command.ExecuteReader();

		if (reader.Read())
		{
			isFound = true;

			TestAppointmentID = (int)reader["TestAppointmentID"];
			LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
			TestTypeTitle = (string)reader["TestTypeTitle"];
			ClassName = (string)reader["ClassName"];
			AppointmentDate = (DateTime)reader["AppointmentDate"];
			PaidFees = (decimal)reader["PaidFees"];
			FullName = (string)reader["FullName"];
			IsLocked = (bool)reader["IsLocked"];

		}
		else
		{
			isFound = false;
		}

		reader.Close();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }

	return isFound;

}
public static int AddNewTestAppointments_View( int LocalDrivingLicenseApplicationID,  string TestTypeTitle,  string ClassName,  DateTime AppointmentDate,  decimal PaidFees,  string FullName,  bool IsLocked){

        int ID = -1;

	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        string query = @"INSERT INTO TestAppointments_View VALUES (@LocalDrivingLicenseApplicationID, @TestTypeTitle, @ClassName, @AppointmentDate, @PaidFees, @FullName, @IsLocked)
        SELECT SCOPE_IDENTITY()";

	SqlCommand command = new SqlCommand(query, connection);


	command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID );

	command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle );

	command.Parameters.AddWithValue("@ClassName", ClassName );

	command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate );

	command.Parameters.AddWithValue("@PaidFees", PaidFees );

	command.Parameters.AddWithValue("@FullName", FullName );

	command.Parameters.AddWithValue("@IsLocked", IsLocked );


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
               
            }

            finally 
            {
                connection.Close(); 
            }


            return ID;

}
public static bool UpdateTestAppointments_View( int TestAppointmentID,  int LocalDrivingLicenseApplicationID,  string TestTypeTitle,  string ClassName,  DateTime AppointmentDate,  decimal PaidFees,  string FullName,  bool IsLocked)
{
	int rowsAffected=0;

	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

	string query = @"UPDATE TestAppointments_View
	SET	LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
	TestTypeTitle = @TestTypeTitle,
	ClassName = @ClassName,
	AppointmentDate = @AppointmentDate,
	PaidFees = @PaidFees,
	FullName = @FullName,
	IsLocked = @IsLocked	WHERE TestAppointmentID = @TestAppointmentID";

	SqlCommand command = new SqlCommand(query, connection);


	command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID );

	command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID );

	command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle );

	command.Parameters.AddWithValue("@ClassName", ClassName );

	command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate );

	command.Parameters.AddWithValue("@PaidFees", PaidFees );

	command.Parameters.AddWithValue("@FullName", FullName );

	command.Parameters.AddWithValue("@IsLocked", IsLocked );


	try {connection.Open(); rowsAffected = command.ExecuteNonQuery();}
	catch (Exception ex) {}
	finally{ connection.Close(); }

	return (rowsAffected > 0);

}
public static bool DeleteTestAppointments_View(int TestAppointmentID)
{
	int rowsAffected = 0;
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "DELETE TestAppointments_View WHERE TestAppointmentID = @TestAppointmentID";
	SqlCommand command = new SqlCommand(query, connection);

	command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID );

	try
	{
		connection.Open();
		rowsAffected = command.ExecuteNonQuery();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }


	return (rowsAffected > 0);

}

public static bool IsTestAppointments_ViewExist(int TestAppointmentID)
{
	bool isFound = false;
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT Found=1 FROM TestAppointments_View WHERE TestAppointmentID= @TestAppointmentID"; 
	SqlCommand command = new SqlCommand(query, connection);

	command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID );

	try
	{
		connection.Open();
		SqlDataReader reader = command.ExecuteReader();
		isFound = reader.HasRows;
		reader.Close();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }


	return isFound;

}

public static DataTable GetAllTestAppointments_View()
{

	DataTable dt = new DataTable();
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM TestAppointments_View";
	SqlCommand command = new SqlCommand(query, connection);

	try
	{
		connection.Open();
		SqlDataReader reader = command.ExecuteReader();
		if (reader.HasRows)dt.Load(reader);
		reader.Close();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }


	return dt;
}


}

}