using BlazorTest.Domain.Entities.Location;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppServer.Model
{
    public class PersonViewModel
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name Is Too Long, Cannot be longer than 100 characters.")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "First Name Is Too Long, Cannot be longer than 100 characters.")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Email Is Too Long, Cannot be longer than 100 characters.")]
        public string Email { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "PhoneNumber Is Too Long, Cannot be longer than 100 characters.")]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Address Is Too Long, Cannot be longer than 100 characters.")]
        public string Address { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public IQueryable<State> States { get; set; }
        public IQueryable<City> Cities { get; set; }
    }
}
