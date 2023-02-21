namespace AutoMaper_API.DataTransferObject
{
    public class UserReadDto
    {
        public string FullName { get; set; } = string.Empty;

        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;

    }
}//so this DTO helps us to select wgich data we want the user to have acess to which are "fullName, Age, Email".
