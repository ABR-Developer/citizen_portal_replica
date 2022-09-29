namespace Citizen_Portal.Models.Interfaces
{
    public interface IComplaineeRepository
    {
        void Add(Complainee complainee);
        void Update(int Id, Complainee complainee);
        void Delete(int Id);
        List<Complainee> GetAll();
        Complainee GetById(int Id);
        bool IsExist(Complainee complainee);
        int getId(Complainee complainee);
    }
}
