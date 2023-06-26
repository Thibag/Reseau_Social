

namespace MVC.Models
{
    public class UserViewModel
    {

        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Naissance { get; set; }

        public string Telephone { get; set; } = string.Empty;
        public AddressViewModel Addresse { get; set; } = new AddressViewModel();
        public List<UserViewModel> Amis { get; set; } = new List<UserViewModel>();
        public string Interets { get; set; } = string.Empty;
    }
}
