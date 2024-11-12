using MyProject.Entities;
using MyProject.Enum;
using MyProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class FakeContext : IDataContext
    {
        public List<User> LoadData()
        {
            return new List<User>() {  new User { FirstName = "Avraham", LastName = "Avraham", Tz = "329146518", Email = "A1@gmail.com", Password = "111", PhoneNumber = "036777777", Address = "Elad", AccountType = AccountType.VISA, IsActive = true } ,
            new User { FirstName = "Beni", LastName = "Benyamin", Tz = "065939597", Email = "B2@gmail.com", Password = "222", PhoneNumber = "036777777", Address = "Bneybrack", AccountType = AccountType.DIRECT, IsActive = true} };          
        }

        public bool SaveData(List<User> users)
        {
           return true;
        }
    }
}
