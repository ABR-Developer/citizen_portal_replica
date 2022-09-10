using Citizen_Portal.Models.Interfaces;
using Microsoft.Data.SqlClient;

namespace Citizen_Portal.Models.Repositories
{
    public class ComplainantRepository : IComplainantRepository
    {
        CitizenPortalDbContext _context;
        public ComplainantRepository()
        {
            _context = new CitizenPortalDbContext();
        }

        public void Add(Complainant complainant)
        {
            _context.complainant.Add(complainant);
            _context.SaveChanges();
        }

        public List<Complainant> GetAll()
        {
            List<Complainant> cList = (List<Complainant>)_context.complainant.Select(x => x);
            return cList;
        }

        public Complainant GetById(int Id)
        {
            Complainant c = (Complainant)_context.complainant.Where(x => x.ID == Id);
            return c;
        }

        public void Update(int Id, Complainant complainant)
        {
            Complainant c = GetById(Id);
            c.name = complainant.name;
            _context.SaveChanges();
        }
        public void Delete(int Id)
        {
            Complainant c = GetById(Id);
            _context.complainant.Remove(c);
            _context.SaveChanges();
        }
    }
}