using AutoMaper_API.DataTransferObject;
using AutoMaper_API.Entities;
using AutoMaper_API.HelperFunction;
using AutoMapper;

namespace AutoMaper_API.AutoMapperProfiles
{
    public class UserProfiles :Profile
    {
        public UserProfiles()
        {         //So we Map by saying
                  //Source -> Destination (source goes to destination)
                  //so there our souce is the User class and Destination is the UserReadDto class  
            CreateMap<User, UserReadDto>()
                     .ForMember(
                dest => dest.FullName,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                     .ForMember(dest => dest.Age, 
                     opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
            //so here we have mapped two member which is the FullName and age
            //  dest = destination , opt = option , src = source . 

            CreateMap<UserCreateDto, User>();
        }
    }
}
