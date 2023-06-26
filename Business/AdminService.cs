using Business.Abstractions;
using Business.Models;
using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Business
{
    public class UserService : IUserService
    {
        // Injection de dépendances
        private readonly ReseauDbContext context;
        public UserService(ReseauDbContext context) { this.context = context; }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await this.context.Users
                .Select(u => new UserDto()
                {
                    Nom = u.Nom,
                    Prenom = u.Prenom,
                    Email = u.Email,
                    Naissance = u.Naissance,
                    Adresse = new AddressDto()
                    {
                        NumeroRue = u.Addresse.NumeroRue,
                        Rue = u.Addresse.Rue,
                        Ville = u.Addresse.Ville,
                        CodePostal = u.Addresse.CodePostal
                    },
                    Telephone = u.Telephone,
                    Interets = u.Interets
                })
                .ToListAsync();

            return users;
        } // OK
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
        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            var user = await this.context.Users.FindAsync(id);

            if (user != null)
            {
                var adress = new AddressDto()
                {
                    NumeroRue = user.Addresse.NumeroRue,
                    Rue = user.Addresse.Rue,
                    Ville = user.Addresse.Ville,
                    CodePostal = user.Addresse.CodePostal
                };

                return new UserDto()
                {
                    Nom = user.Nom,
                    Prenom = user.Prenom,
                    Email = user.Email,
                    Naissance = user.Naissance,
                    Adresse = adress,
                    Telephone = user.Telephone,
                    Interets = user.Interets
                };
            }
            else
            {
                return new UserDto();
            }
        } // OK
        public async Task UpdateUserAsync(int id, UserDto userDto)
        {
            var user = await this.context.Users.FindAsync(id);

            if (user != null)
            {
                var address = new Address()
                {
                    NumeroRue = userDto.Adresse.NumeroRue,
                    Rue = userDto.Adresse.Rue,
                    Ville = userDto.Adresse.Ville,
                    CodePostal = userDto.Adresse.CodePostal
                };

                user.Nom = userDto.Nom;
                user.Prenom = userDto.Prenom;
                user.Email = userDto.Email;
                user.Naissance = userDto.Naissance;
                user.Addresse = address;
                user.Telephone = userDto.Telephone;
                user.Interets = userDto.Interets;

                await this.context.SaveChangesAsync();
            }
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