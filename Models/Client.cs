using System.ComponentModel.DataAnnotations;

namespace HotelAnnotations.Models
{
    public class Client
    {
        [Numeric]
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; }
        
        [StringLength(25, MinimumLength =3)]
        [Required]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone number")]
        public string PhoneNumber { get; set; }

    }
}
