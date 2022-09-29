namespace Citizen_Portal.Models.Interfaces
{
    public interface IComplainantRepository
    {
        void Add(Complainant complainant);
        void Update(int Id, Complainant complainant);
        void Delete(int Id);
        List<Complainant> GetAll();
        Complainant GetById(int Id);
        bool IsExist(Complainant complainant);
        int getId(Complainant complainant);
    }
}
