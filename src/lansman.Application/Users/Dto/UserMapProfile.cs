using AutoMapper;
using lansman.Authorization.Users;

namespace lansman.Users.Dto
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<UserDto, User>()
                .ReverseMap();
            CreateMap<UserDto, User>()
                .ForMember(x => x.Roles, opt => opt.Ignore())
                .ForMember(x => x.CreationTime, opt => opt.Ignore());

            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, User>()
                .ForMember(x => x.Roles, opt => opt.Ignore())
                .ForMember(x=>x.UserAddresses,opt=>opt.MapFrom(src=>src.UserAddresses))
                .ReverseMap();

            CreateMap<CreateUserAddressDto, UserAddress>()
                .ReverseMap();
        }
    }
}
