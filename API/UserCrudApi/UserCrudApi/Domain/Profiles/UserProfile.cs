using AutoMapper;
using UserCrudApi.Domain.Dto;
using UserCrudApi.Domain.Model;

namespace UserCrudApi.Domain.Profiles;

public class UserProfile : Profile
{
    public UserProfile() {
        CreateMap<UserRegisterDto, User>();
        CreateMap<User, UserProfileDto>();



    
    }

}
