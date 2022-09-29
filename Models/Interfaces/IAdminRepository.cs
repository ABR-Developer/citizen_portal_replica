namespace Citizen_Portal.Models.Interfaces
{
    public interface IAdminRepository
    {
        public bool IsExist(Admin admin);
        //void Add(Admin admin);
        //void Update(int Id, Admin admin);
        List<Admin> GetAll();
        public int getId(Admin admin);
    }
}
