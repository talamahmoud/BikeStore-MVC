using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModel
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Category name is req")]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

    }
}
