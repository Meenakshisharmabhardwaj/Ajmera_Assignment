using System.ComponentModel.DataAnnotations;

namespace WebApplicationCoreWebApi.Models.RequestModels
{
    public class BookModel
    {
        [Required]
        public string? BookName { get; set; }
        [Required]
        public string? AuthorName { get; set; }
    }
}
