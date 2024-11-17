using MyProject.Entities;

namespace MyProject.Interface
{
    public interface IDataContext
    {
         List<T> LoadData<T>();
         bool SaveData<T>(List<T> data);
    }
}
