using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment_Data;

namespace LibraryManagment_business
{
    public class clsAdmin
    {
        public enum enMode { AddNew = 0,Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? AdminID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public clsAdmin()
        {
            this.AdminID = null;
            this.Name = "";
            this.Username = "";
            this.PasswordHash = "";
            this.Role = "";
            this.Mode = enMode.AddNew;
        }
        private clsAdmin(int? AdminID, string Name, string Username, string PasswordHash, string Role)
        {
            this.AdminID = AdminID;
            this.Name = Name;
            this.Username = Username;
            this.PasswordHash = PasswordHash;
            this.Role = Role;
            this.Mode = enMode.Update;
        }

        private bool _AddNewAdmin()
        {
            this.AdminID = clsAdminData.AddNewAdmin(this.Name, this.Username, this.PasswordHash, this.Role);

            return (AdminID != null);
        }
        private bool _UpdateAdmin()
        {
            return clsAdminData.UpdateAdmin(this.AdminID, this.Name, this.Username, this.PasswordHash, this.Role);
        }

        public static clsAdmin FindByAdminID(int? AdminID)
        {
            string Name = "", Username = "", PasswordHash = "", Role = "";

            bool isFound = clsAdminData.GetAdminInfoByAdminID(AdminID, ref Name,ref Username,ref PasswordHash,ref Role);

            if (isFound)
            {
                return new clsAdmin(AdminID, Name, Username, PasswordHash, Role);
            }
            else
                return null;
        }
        public static clsAdmin FindByUsernameAndPassword(string Username,string PasswordHash)
        {
           
            int AdminID = 0;

            string Name = "", Role = "";

            bool isFound = clsAdminData.GetAdminInfoByUsernameAndPassword(Username, PasswordHash, ref AdminID, ref Name, ref Role);

            if(isFound)
            {
                return new clsAdmin(AdminID, Name, Username, PasswordHash, Role);
            }
            else 
            { 
                return null;
            }


        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewAdmin())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                case enMode.Update:
                    return _UpdateAdmin();
            }
            return false;
        }
        public static DataTable GetAllAdmins()
        {
            return clsAdminData.GetAllAdmins();
        }
        public bool DeleteAdmin(int AdminID)
        {
            return clsAdminData.DeleteAdmin(AdminID);
        }
        public static bool isAdminExist(int AdminID)
        {
            return clsAdminData.IsAdminExist(AdminID);
        }
        public static bool isAdminExist(string Username)
        {
            return clsAdminData.IsAdminExist(Username);
        }


    }
}
