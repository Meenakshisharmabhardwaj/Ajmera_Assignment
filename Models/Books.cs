using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCoreWebApi.Models
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid BookId { get; set; }
        [DisplayName("Name")]
        public string? BookName { get; set; }
        public string? AuthorName { get; set; }
    }
}
