using Business.Abstractions;
using Business.Models;
using DAL;
using DAL.Entities;

namespace Business
{
    public class AdminService : IAdminService
    {
        // Injection de dépendances
        private readonly ReseauDbContext context;
        public AdminService(ReseauDbContext context){ this.context = context; }

        public async Task CreateUserAsync(UserDto userDto)
        {
            var address = new Address()
            {
                NumeroRue = userDto.Adresse.NumeroRue,
                Rue = userDto.Adresse.Rue,
                Ville = userDto.Adresse.Ville,
                CodePostal = userDto.Adresse.CodePostal
            };

            var user = new User()
            {
                Nom = userDto.Nom,
                Prenom = userDto.Prenom,
                Email = userDto.Email,
                Naissance = userDto.Naissance,
                Addresse = address,
                Telephone = userDto.Telephone,
                Interets = userDto.Interets
            };

            this.context.Users.Add(user);
            await this.context.SaveChangesAsync();
        } // OK
        public async Task DeleteUserAsync(int id)
        {
            var user = await this.context.Users.FindAsync(id);

            if (user != null)
            {
                this.context.Users.Remove(user);
                await this.context.SaveChangesAsync();
            }
        } // OK
    }
}