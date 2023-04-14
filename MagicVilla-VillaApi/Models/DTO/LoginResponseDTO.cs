namespace MagicVilla_VillaApi.Models.DTO
{
    public class LoginResponseDTO
    {
        public UserDto User { get; set; }        
        public string Token { get; set; }
    }
}
