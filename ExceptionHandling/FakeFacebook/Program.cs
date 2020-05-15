using FakeFacebook.Logger;
using System;
using WebApi.Exceptions;
using WebApi.Models;
using WebApi.Service;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region USER
            var allUsers = UserService.GetAllUsers();

            //foreach (var user  in allUsers)
            //{
            //    Console.WriteLine(user.FirstName);
            //}           

            try
            {
                //var userById = UserService.GetUserById(4);
                var userFrineds = UserService.GetUsersFriends(null);
                userFrineds.ForEach(user => Console.WriteLine(user.FirstName));

                //Console.WriteLine(userById.FirstName);

            }
            catch (UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I proceed to work!");
            #endregion
            
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;

            #region ADMIN
            // ADMIN
            var allAdmins = AdminService.GetAdmins();
            allAdmins.ForEach(admin => Console.WriteLine(admin.FirstName));
            Console.WriteLine("--------------------------------------------");

            try
            {
                var adminId = AdminService.GetAdminById(5);
                Console.WriteLine($"{adminId.FirstName} {adminId.LastName}");

                Console.WriteLine("--------------------------------------------");

                //var adminSupervision = AdminService.AdminSupervisor(adminId);

                var adminSupervision = AdminService.AdminSupervisor(null);
                adminSupervision.ForEach(admin => Console.WriteLine(admin.FirstName));
            }
            catch(AdminServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                var adminLogger = new AdminExceptionLogger();
                adminLogger.AdminLogException(ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Admin continue with Supervision... :)");
            }
            
            #endregion
            Console.ReadLine();
        }
    }
}
