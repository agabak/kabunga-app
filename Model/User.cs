using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "First name must be less than 500")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "Last name must be less than 500")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
        public int AddressId { get; set; }
        public IEnumerable<Address> Addresses { get; set; }

    }
}