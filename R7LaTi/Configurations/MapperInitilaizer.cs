using AutoMapper;
using R7LaTi.Models;
using R7LaTi.ViewModel;

namespace R7LaTi.Configurations
{
    public class MapperInitilaizer : Profile
    {
        MapperInitilaizer()
        {
            CreateMap<Trip , TripVM>().ReverseMap();

            CreateMap<Customer , CustomerVM>().ReverseMap();

            CreateMap<Organizer , OrganizerVM>().ReverseMap();
        }
    }
}