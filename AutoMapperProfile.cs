using AutoMapper;

namespace AutoMapperSample
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}