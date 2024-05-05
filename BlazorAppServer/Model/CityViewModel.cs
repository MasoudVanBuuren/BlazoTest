using BlazorTest.Domain.Entities.Location;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppServer.Model
{
    public class CityViewModel
    {
        public int StateId { get; set; }
        public int CityId { get; set; }
        public IQueryable<State> States { get; set; }
        public IQueryable<City> Cities { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Title Is Too Long, Cannot be longer than 100 characters.")]
        public string Name { get; set; }
    }
}
