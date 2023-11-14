using ShopSellShoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ShopSellShoes.Controllers
{
    public class UsersController : Controller
    {

        private Model1 db = new Model1();
        // GET: Users
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            if (ModelState.IsValid)
            {
                string username = Username.Trim();
                string password = Password.Trim();
                if (username == "" || password == "")
                {
                    ViewBag.Notification = "Please complete all information";
                }
                else
                {
                    var data = db.Users.FirstOrDefault(s => s.UserName == username);
                    if (data != null)
                    {
                        if (data.PassWord == password)
                        {
                            Session["UserID"] = data.UserID;
                            Session["UserName"] = data.UserName;
                            Session["Email"] = data.Email;
                            Session["PhoneNumber"] = data.PhoneNumber;
                            Session["Address"] = data.Address;

                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ViewBag.Notification = "Incorrect password";
                        }
                    }
                    else
                    {
                        ViewBag.Notification = "Username does not exist";
                    }
                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(string Username, string Email, string Password, string ConfirmPassword, string  PhoneNumber, string Address )
        {
            if (ModelState.IsValid)
            {
                string username = Username.ToString();
                string email = Email.ToString();
                string password = Password.ToString();
                string confirmPassword = ConfirmPassword.ToString();
                string phone = PhoneNumber.ToString();
                string address = Address.ToString();
                var data = db.Users.FirstOrDefault(s => s.UserName == username);

                if (username == "" || password == "" || confirmPassword == "" || phone == "" || email == "" || address == "")
                {
                    ViewBag.Notification = "Please complete all information";
                }
                else if (data != null)
                {
                    ViewBag.Notification = "Username already exists";
                }
                else if (password != confirmPassword)
                {
                    ViewBag.Notification = "Password does not match";
                }
                else
                {
                    User user = new User();
                    user.UserName = username;
                    user.Email = email;
                    user.PassWord = password;
                    user.PhoneNumber = phone;
                    user.Address = address;
                    db.Users.Add(user);
                    db.SaveChanges();

                    return RedirectToAction("Login");
                }
            }

            return View();
        }
    }
}