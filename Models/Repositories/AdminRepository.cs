namespace Citizen_Portal.Models.Repositories
{
    public class AdminRepository
    {
        CitizenPortalDbContext _context;
        public AdminRepository(CitizenPortalDbContext context)
        {
            _context = context;
        }

        public bool IsExist(string name ,string password)
        {
            var c = _context.admin.Where(x => x.name == name).Where(y => y.password == password);
            return false;
        }
    }
}
