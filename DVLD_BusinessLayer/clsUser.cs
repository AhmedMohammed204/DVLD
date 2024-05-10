using System;
using System.Data;
using UsersDataAccessLayer;
namespace UsersBusinessLayer
{

    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAcvite { get; set; }


        public clsUser()
        {
            this.UserID = default;
            this.PersonID = default;
            this.UserName = default;
            this.Password = default;
            this.IsAcvite = default;


            Mode = enMode.AddNew;

        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsAcvite)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsAcvite = IsAcvite;


            Mode = enMode.Update;

        }

        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsAcvite);

            return (this.UserID != -1);

        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUsersDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsAcvite);

        }

        public static clsUser Find(int UserID)
        {
            int PersonID = default;
            string UserName = default;
            string Password = default;
            bool IsAcvite = default;


            if (clsUsersDataAccess.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsAcvite))
                return new clsUser(UserID, PersonID, UserName, Password, IsAcvite);
            else
                return null;

        }
        
        public static clsUser Find(string UserName)
        {
            int UserID= default;
            int PersonID = default;
            string Password = default;
            bool IsAcvite = default;


            if (clsUsersDataAccess.GetUserInfoByUserName(ref UserID, ref PersonID, ref UserName, ref Password, ref IsAcvite))
                return new clsUser(UserID, PersonID, UserName, Password, IsAcvite);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }




            return false;
        }

        public static DataTable GetAllUsers() { return clsUsersDataAccess.GetAllUsers(); }
        public static DataTable GetAllUsersMaster() { return clsUsersDataAccess.GetAllUsers_Master(); }

        public static bool DeleteUser(int UserID) { return clsUsersDataAccess.DeleteUser(UserID); }

        public static bool isUserExist(int UserID) { return clsUsersDataAccess.IsUserExist(UserID); }

        public static bool isUserExist(string UserName) { return clsUsersDataAccess.IsUserExist(UserName); }
        
        public static bool isUserExistByPersonID(int PersonID) { return clsUsersDataAccess.IsUserExistByPersonID(PersonID); }


    }

}