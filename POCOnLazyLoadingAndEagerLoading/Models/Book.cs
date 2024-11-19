using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POCOnLazyLoadingAndEagerLoading.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Author Author { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}
