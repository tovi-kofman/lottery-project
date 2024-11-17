using MyProject.Enum;
using MyProject.Services;

namespace MyProject.Entities
{
    public class User
    {
        
        //public int UserId { get; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Tz { get; set; }

        //public string Email { get; set; }
        //public string Password { get; set; }

        //public string PhoneNumber { get; set; }
        //public string Address { get; set; }
        //public bool IsActive { get; set; }
        //public AccountType AccountType { get; set; }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string AccountType { get; set; }

        public User(int userId,string firstName, string lastName, string tz, string email, string password, string phoneNumber, string address, bool isActive, string accountType)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            //IsActive = true;
            AccountType = accountType;
            TzValid tzValid = new TzValid();
            ErrorTZ error;
            if (tzValid.ISOK(tz, out error))
            {
                Tz = tz;
            }
            else 
            { 
                throw new Exception($"{error}");
            }
        }

        //public User()
        //{
        //    UserId = id++;
        //}
    }
}
