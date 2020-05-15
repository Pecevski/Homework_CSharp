using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;

namespace WebApi.Service
{
    public class AdminService
    {
        public static List<Admin> GetAdmins()
        {
            return DB.Admins;
        }

        public static Admin GetAdminById(int id)
        {
            Admin admin = DB.Admins.Single(admin => admin.Id == id);
            return admin;
        }

        public static List<Admin> AdminSupervisor(Admin adminSupervisor)
        {
            try
            {
                //if(adminSupervisor == null)
                //{
                //    throw new AdminServiceException("You have input a null", new Exception());
                //}
                var findAdminSupervisor = DB.Admins.Single(admin => admin.Equals(adminSupervisor));
                return findAdminSupervisor.Supervisor;
            }
            catch (ArgumentNullException ex)
            {
                throw new AdminServiceException("You have input a null", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
