using Citizen_Portal.Models.Interfaces;

namespace Citizen_Portal.Models.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly CitizenPortalDbContext _context;

        public AdminRepository()
        {
            _context = new CitizenPortalDbContext();
        }
        //public Admin GetById(int Id)
        //{
        //    Admin a = _context.admin.Where(x => x.Id == Id).FirstOrDefault();
        //    return a;
        //}

        //public void Add(Admin admin)
        //{
        //    _context.Add(new Admin { Id = admin.Id, name = admin.name , password = admin.password});
        //    _context.SaveChanges();
        //}

        public List<Admin> GetAll()
        {
            List<Admin> aList = (List<Admin>)_context.admin.Select(x => x);
            return aList;
        }


        public bool IsExist(Admin admin)
        {
            var a = _context.admin.Where(x => x.name == admin.name && x.password == admin.password).FirstOrDefault();
            if (a != null)
            {
                return true;
            }
            return false;
        }

        //public void Update(int Id, Admin admin)
        //{
        //    Admin a = GetById(Id);
        //    a.name = admin.name;
        //    a.password = admin.password;
        //    _context.SaveChanges();
        //}
        public int getId(Admin admin)
        {
            var a = _context.admin.Where(x => x.name == admin.name && x.password == admin.password).Select(x => x.Id).FirstOrDefault();
            return a;
        }
    }
}
