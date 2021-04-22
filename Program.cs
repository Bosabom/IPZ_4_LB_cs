using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Threading;
using IPZ_Proj.Exceptions;
using IPZ_Proj.Service;
using MySql.Data.MySqlClient;

namespace IPZ_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuctionCarService auctionCarService = new AuctionCarService();
            IAuctionLotService auctionLotService = new AuctionLotService();
            IAuctionPhotoService auctionPhotoService = new AuctionPhotoService();
            ICarService carService = new CarService();
            ICarOwnerService carOwnerService = new CarOwnerService();
            IPhotosService photosService = new PhotosService();
            IUsersCarService usersCarService = new UsersCarService();
            IUsersPhotosService usersPhotosService = new UsersPhotosService();

            IOrderService orderService = new OrderService();
            IUserService userService = new UserService();


            try
            {
                auctionCarService.ChangeBrand("");
            }
            catch (EmptyStringException e)
            {
                Console.WriteLine("Message : " + e.Message + 
                                  "\nTime : " + DateTime.Now + 
                                  "\nStacktrace : " + e.StackTrace + 
                                  "\nThread : " + Thread.CurrentThread + 
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                auctionCarService.ChangeCondition("nn");
            }
            catch (ConditionException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                auctionCarService.ChangeFuel("Gg");
            }
            catch (FuelException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                auctionCarService.ChangeYear(0);
            }
            catch (InvalidYearException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                auctionCarService.ChangeHP(0);
            }
            catch (ZeroException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                userService.ChangeEmail("fsdf");
            }
            catch (InvalidEmailException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                userService.ChangeLogin("");
            }
            catch (InvalidLoginException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                userService.ChangePassword("");
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                userService.ChangeRole("");
            }
            catch (InvalidRoleException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }

            Console.WriteLine();

            try
            {
                usersPhotosService.ChangePhoto("fs");
            }
            catch (InvalidPathException e)
            {
                Console.WriteLine("Message : " + e.Message +
                                  "\nTime : " + DateTime.Now +
                                  "\nStacktrace : " + e.StackTrace +
                                  "\nThread : " + Thread.CurrentThread +
                                  "\nProcessId : " + Process.GetCurrentProcess().Id);
            }
        }
    }
}
