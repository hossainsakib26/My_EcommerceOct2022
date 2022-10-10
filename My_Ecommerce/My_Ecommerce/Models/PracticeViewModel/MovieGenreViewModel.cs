using Microsoft.AspNetCore.Mvc.Rendering;
using My_Ecommerce.Models.PracticeModel;

namespace My_Ecommerce.Models.PracticeViewModel
{
	public class MovieGenreViewModel
	{
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
