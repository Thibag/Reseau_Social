using Business.Models;
using DAL.Entities;

namespace Business.Abstractions
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task CreateUserAsync(UserDto userDto);
        Task<UserDto> GetUserByIdAsync(int id);
        Task UpdateUserAsync(int id, UserDto userDto);
        Task DeleteUserAsync(int id);
    }
}
