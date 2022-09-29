using Citizen_Portal.Models.Interfaces;

namespace Citizen_Portal.Models.Repositories
{
    public class ComplaineeRepository : IComplaineeRepository
    {
        private readonly CitizenPortalDbContext _context;
        
        public ComplaineeRepository()
        {
            _context = new CitizenPortalDbContext();
        }
        
        public void Add(Complainee complainee)
        {
            _context.Add(new Complainee
            {
                office_landline_number = complainee.office_landline_number,
                email = complainee.email,
                password = complainee.password,
                name = complainee.name,
                nic_number = complainee.nic_number,
                gender = complainee.gender,
                province = complainee.province,
                district = complainee.district,
                tehsil = complainee.tehsil,
                office_address = complainee.office_address,
                working_field = complainee.working_field,
                profile_image = complainee.profile_image,
                term_accepted = complainee.term_accepted
            });
            _context.SaveChanges();
        }

        public void Update(int Id, Complainee complainee)
        {
            Complainee c = GetById(Id);
            c.name = complainee.name;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            Complainee c = GetById(Id);
            _context.complainee.Remove(c);
            _context.SaveChanges();
        }

        public List<Complainee> GetAll()
        {
            List<Complainee> cList = (List<Complainee>)_context.complainee.Select(x => x);
            return cList;
        }

        public Complainee GetById(int Id)
        {
            var c = _context.complainee.Where(x => x.ID == Id);
            return (Complainee)c;
        }

        public bool IsExist(Complainee complainee)
        {
            var a = _context.complainee.Where(x => x.nic_number == complainee.nic_number && x.password == complainee.password).FirstOrDefault();
            if (a != null)
            {
                return true;
            }
            return false;
        }
        
        public int getId(Complainee complainee)
        {
            var a = _context.complainee.Where(x => x.nic_number == complainee.nic_number && x.password == complainee.password).Select(x => x.ID).FirstOrDefault();
            return a;
        }
    }
}
