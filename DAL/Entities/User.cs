using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Naissance { get; set; }

        public string Telephone { get; set; } = string.Empty;
        public Address Addresse { get; set; } = new Address();
        public List<User> Amis { get; set; } = new List<User>();
        public string Interets { get; set; } = string.Empty;
    }
}
