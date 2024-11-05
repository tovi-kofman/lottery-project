using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;
using System;

namespace MyProject.Services
{
    public class UserService
    {
        public List<User> Users { get; set; }
        public List<User> GetUsers()
        {
            return Users;
        }
        public User GetUserById(int id)
        {
            return Users.FirstOrDefault(x => x.UserId == id);
        }
        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public ActionResult UpdateUser(int id,User user)
        {
            foreach (User u in Users)
            {
                if (u.UserId == id)
                {
                    Users.Insert(Users.IndexOf(u),user);
                    //u.Address = user.Address;
                    //u.Password = user.Password;
                    //u.Email = user.Email;
                    //u.FirstName = user.FirstName;
                    //u.LastName = user.LastName;
                    //u.PhoneNumber = user.PhoneNumber;
                    //u.AccountType = user.AccountType;
                    //u.UserId = user.UserId;
                    return new OkResult();
                }
            }
            return new NotFoundResult();
        }
        public ActionResult<bool> RemoveUser(int id)
        {
            return Users.Remove(Users.FirstOrDefault(x => x.UserId== id));
        }
    }
}