using AutoMapper;
using Citizen_Portal.Models;
using Citizen_Portal.Models.ViewModels;

namespace Citizen_Portal.MapperConfigurations
{
    public class ComplainantAutoMaper : Profile
    {
        public ComplainantAutoMaper()
        {
            CreateMap<Complainant, ComplainantLoginViewModel>();
            CreateMap<Complainant, ComplainantLoginViewModel>().ReverseMap();

            CreateMap<Complainant, ForeignerViewModel>();
            CreateMap<Complainant, ForeignerViewModel>().ReverseMap();

            CreateMap<Complainant, InlandViewModel>();
            CreateMap<Complainant, InlandViewModel>().ReverseMap();

            CreateMap<Complainant, OverseasViewModel>();
            CreateMap<Complainant, OverseasViewModel>().ReverseMap();
        }
    }
}
