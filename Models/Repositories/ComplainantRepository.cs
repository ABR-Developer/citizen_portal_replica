using Citizen_Portal.Models.Interfaces;
using Microsoft.Data.SqlClient;

namespace Citizen_Portal.Models.Repositories
{
    public class ComplainantRepository : IComplainantRepository
    {
        private readonly CitizenPortalDbContext _context;
        public ComplainantRepository()
        {
            _context = new CitizenPortalDbContext();
        }

        public void Add(Complainant complainant)
        {
            _context.Add(new Complainant { 
                mobile_number = complainant.mobile_number,
                email = complainant.email,
                name = complainant.name,
                nic_number = complainant.nic_number,
                nationality = complainant.nationality,
                residential_address = complainant.residential_address,
                date_of_birth = complainant.date_of_birth,
                gender = complainant.gender,
                telephone_number = complainant.telephone_number,
                password = complainant.password,
                province = complainant.province,
                district = complainant.district,
                tehsil = complainant.tehsil,
                permanent_address = complainant.permanent_address,
                profile_image = complainant.profile_image,
                term_accepted = complainant.term_accepted,
                reason_abroad = complainant.reason_abroad,
                abroad_country = complainant.abroad_country,
                reason_visit_pakistan = complainant.reason_visit_pakistan
            });
            _context.SaveChanges();
        }

        public List<Complainant> GetAll()
        {
            List<Complainant> cList = (List<Complainant>)_context.complainant.Select(x => x);
            return cList;
        }

        public Complainant GetById(int Id)
        {
            var c = _context.complainant.Where(x => x.ID == Id);
            return (Complainant)c;
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

        public bool IsExist(Complainant complainant)
        {
            var a = _context.complainant.Where(x => x.nic_number == complainant.nic_number && x.password == complainant.password).FirstOrDefault();
            if (a != null)
            {
                return true;
            }
            return false;
        }
        public int getId(Complainant complainant)
        {
            var a = _context.complainant.Where(x => x.nic_number == complainant.nic_number && x.password == complainant.password).Select(x => x.ID).FirstOrDefault();
            return a;
        }
    }
}