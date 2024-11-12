using MyProject.Entities;

namespace MyProject.Interface
{
    public interface IDataContext
    {
        public List<User> LoadData();
        public bool SaveData(List<User> users);
    }
}
