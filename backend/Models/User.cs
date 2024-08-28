using backend.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class User : BaseModel
    {
        public required string Firstname { get; set; }

        public required string Lastname { get; set; }

        public required string Username { get; set; }

        public string? Age { get; set; }

        public required string EmailAddress { get; set; }

        public string? Profession { get; set; }

        public UserDTO ToUserDTO()
        {
            return new UserDTO
            {
                Firstname = Firstname,
                Lastname = Lastname,
                Username = Username,
                Age = Age,
                EmailAddress = EmailAddress,
                Profession = Profession
            };
        }
    }
}
