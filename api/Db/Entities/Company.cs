using System;
using System.ComponentModel.DataAnnotations;

namespace api.Db.Entities
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Street { get; set; }

        [MaxLength(250)]
        public string City { get; set; }

        public string PostalCode { get; set; }

        [Url]
        public string Website { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [MaxLength(500)]
        public string InternalNotes { get; set; }
    }
}
