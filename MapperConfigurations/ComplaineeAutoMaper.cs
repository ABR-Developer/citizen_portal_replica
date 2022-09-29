using AutoMapper;
using Citizen_Portal.Models;
using Citizen_Portal.Models.ViewModels;

namespace Citizen_Portal.MapperConfigurations
{
    public class ComplaineeAutoMaper : Profile
    {
        public ComplaineeAutoMaper()
        {
            CreateMap<Complainee, ComplaineeLoginViewModel>();
            CreateMap<Complainee, ComplaineeLoginViewModel>().ReverseMap();
        }
    }
}
