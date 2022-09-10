using AutoMapper;
using Citizen_Portal.Models;
using Citizen_Portal.Models.ViewModels;

namespace Citizen_Portal.MapperConfigurations
{
    public class ComplainantAutoMapper
    {
        public ComplainantAutoMapper()
        {
            // Default mapping when property names are same
            //CreateMap<Complainant, ComplainantViewModel>();

            // Mapping when property names are different
            /* CreateMap<User, UserViewModel>()
                 .ForMember(dest =>
                 dest.FName,+
                 opt => opt.MapFrom(src => src.FirstName))
                 .ForMember(dest =>
                 dest.LName,
                 opt => opt.MapFrom(src => src.LastName));*/
        }
    }
}
