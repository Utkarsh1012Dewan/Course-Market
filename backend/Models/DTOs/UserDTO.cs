namespace backend.Models.DTOs
{
    public class UserDTO
    {
        public required string Firstname { get; set; }

        public required string Lastname { get; set; }

        public required string Username { get; set; }

        public string? Age { get; set; }

        public required string EmailAddress { get; set; }

        public string? Profession { get; set; }
    }
}
