using Business.Models;
using DAL.Entities;

namespace Business.Abstractions
{
    public interface IAdminService
    {
        Task CreateUserAsync(UserDto userDto); // Créer un utilisateur
        Task UpdateUserAsync(UserDto userDto); // Modifie un utilisateur
        Task DeleteUserAsync(int id); // Supprime l'utilisateur d'id donné
    }
}
