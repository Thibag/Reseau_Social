namespace Business.Models
{
    public class AddressDto
    {
        public int NumeroRue { get; set; }
        public string Rue { get; set; } = string.Empty;
        public string Ville { get; set; } = string.Empty;
        public string CodePostal { get; set; } = string.Empty;
    }
}
