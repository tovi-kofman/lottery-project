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
        public DataContext()
        {

        }

        //public string Combine(string name)
        //{

        //}
        public List<T> LoadData<T>()
        {
            //string path = Path.Combine(AppContext.TargetFrameworkName, "Data");
            string path = @"C:\Users\user1\Desktop\dotenet project\MyProject\Data\Data.json";

            string jsonString = File.ReadAllText(path);
            //var AllUsers = JsonSerializer.Deserialize<DataUsers>(jsonString);// typeof(DataUsers)); ;
            var data = JsonSerializer.Deserialize<Data<T>>(jsonString);
            return data.db;
        }


        public bool SaveData<T>(List<T> data)
        {
            try
            {
                string path = @"C:\Users\user1\Desktop\dotenet project\MyProject\Data\Data.json";
                //string path = Path.Combine(AppContext.BaseDirectory, "Data");

                Data<T> dataToSave = new Data<T> { db = data };
                var jsonString = JsonSerializer.Serialize<Data<T>>(dataToSave);

                //string jsonString = JsonConvert.SerializeObject(dataToSave, Formatting.Indented);
                //= JsonSerializer.Serialize<DataUsers>(dataUsers);
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
