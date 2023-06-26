namespace API.ViewModels
{
    public class UserModel
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime Naissance { get; set; }
        public string Telephone { get; set; }
        public AddressModel Addresse { get; set; }
        public string Interets { get; set; }
    }
}
