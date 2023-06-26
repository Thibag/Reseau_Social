using DAL.Entities;

namespace Business.Models
{
    public class UserDto
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Naissance { get; set; }
        public AddressDto Adresse { get; set; } = new AddressDto();
        public string Telephone { get; set; } = string.Empty;
        public string Interets { get; set; } = string.Empty;
    }
}
