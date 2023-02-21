using AutoMaper_API.DataTransferObject;
using AutoMaper_API.Entities;
using AutoMaper_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMaper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController (IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        //GET: api/<UsersController>
        [HttpGet]  //This is GET All

        public ActionResult<List<UserReadDto>> Get()
        {
            var users = _userRepository.GetAllUser();
            var usersReadDto = _mapper.Map<List<UserReadDto>>(users);  //so this collect data object directly from UserReadDto class
            return Ok(usersReadDto);
        }

        //GET : api/<UsersController>

        [HttpGet("{id}")]
        public ActionResult<List<UserReadDto>> Get(Guid id)
        {
            var user = _userRepository.GetUserById(id);
            //var userReadDto = new UserReadDto()
            //{
            //    FullName = $" { user.FirstName } { user.LastName }",
            //    Age = HelperFunction.HelperFunction.GetCurrentAge(user.DateOfBirth),
            //    Email = user.Email
            //};
            var userReadDto = _mapper.Map<UserReadDto>(user);//So here it will be destination to source
             //so my destination is "UserReadDto" and my source is  "user" 
            return Ok(userReadDto);
        }


        //GET : api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] UserCreateDto user)
        {
            //Map CreateDto to User
            var createdUser = _mapper.Map<User>(user);
            //Create User
            var createdUserRepo  = _userRepository.CreateUser(createdUser);
            //Map user to read Dto
            var userReadDto = _mapper.Map<UserReadDto>(createdUserRepo);
            return Ok(createdUser);

        }
    }
}
