using MyProject.Enum;
using MyProject.Services;

namespace MyProject.Entities
{
    public class User
    {
        public static int id;
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

        public int UserId { get; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Tz { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
        public AccountType? AccountType { get; set; }

        public User(string firstName, string lastName, string tz, string email, string password, string phoneNumber, string address, AccountType accountType,bool isActive)
        {
            UserId = id++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            //IsActive = true;
            AccountType = accountType;
            IsActive = isActive;
            TzValid tzValid = new TzValid();
            ErrorTZ error;
            if (tzValid.ISOK(tz, out error))
            {
                Tz = tz;
            }
            else { Console.WriteLine(error); }
        }

        public User()
        {
            UserId = id++;
        }
    }
}
