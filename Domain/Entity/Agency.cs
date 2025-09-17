using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Agency
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string NameEn { get; set; }

        [Required, MaxLength(50)]
        public string LegalCode { get; set; }

        [Required, MaxLength(50)]
        public string RegistrationNo { get; set; }

        [Required, MaxLength(300)]
        public string Address { get; set; }

        [Required, MaxLength(100)]
        public string City { get; set; }

        [Required, MaxLength(100)]
        public string Province { get; set; }

        [Required, MaxLength(20)]
        public string PostalCode { get; set; }

        [Required, Phone, MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Website { get; set; }

        [Required, MaxLength(150)]
        public string ContactPersonName { get; set; }

        [Required, MaxLength(100)]
        public string ContactPersonRole { get; set; }

        [Required, Phone, MaxLength(20)]
        public string ContactPersonPhone { get; set; }

        [Required, EmailAddress, MaxLength(150)]
        public string ContactPersonEmail { get; set; }

        [Required]
        public DateTime EstablishedDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public Country Country { get; set; }
    }
}
