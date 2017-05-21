using AutoMapper;
using VidleyMVC.Dtos;
using VidleyMVC.Models;

namespace VidleyMVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
            Mapper.CreateMap<GenreType, GenreTypeDTO>();



            Mapper.CreateMap<CustomerDTO, Customer>().
                ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDTO, Movie>().
                ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}