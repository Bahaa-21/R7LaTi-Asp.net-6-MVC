using AutoMapper;
using R7LaTi.Models;
using R7LaTi.ViewModel;

namespace R7LaTi;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Trip, TripVM>().ReverseMap();

        CreateMap<Customer, CustomerVM>().ReverseMap();

        CreateMap<Organizer, OrganizerVM>().ReverseMap();
    }
}
