namespace ServerGame2024.DTO
{
    public class ChangePasswordDTO
    {
        public string UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
