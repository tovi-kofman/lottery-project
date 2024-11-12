using MyProject.Entities;
using MyProject.Enum;
using MyProject.Interface;
using System.Text.Json;
using System.IO;
using System.Diagnostics;

namespace MyProject.DTO
{
    public class DataContext:IDataContext
    {
        public List<User> Users { get; set; }
        public DataContext()
        {

        }

        public List<User> LoadData()
        {
            // string path = Path.Combine(AppContext.BaseDirectory, "Data", "Data.json");

            string path = @"C:\Users\user1\Desktop\dotenet project\MyProject\Data\Data.json";

            string jsonString = File.ReadAllText(path);
            var AllUsers = JsonSerializer.Deserialize<DataUsers>(jsonString);// typeof(DataUsers)); ;

            return AllUsers.db;
        }


        public bool SaveData(List<User> users)
        {
            try
            {

                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");


                DataUsers dataUsers = new DataUsers();
                dataUsers.db = users;
                string jsonString = JsonSerializer.Serialize<DataUsers>(dataUsers);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
