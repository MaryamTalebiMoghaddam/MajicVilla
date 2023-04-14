using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Models.DTO;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqeUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDto> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
