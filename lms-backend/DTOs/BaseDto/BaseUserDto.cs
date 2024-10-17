namespace lms_backend.DTOs.BaseDto
{
    public class BaseUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
