using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSchool.Data.Models
{
    public class Author
    {
        public Author()
        {
            this.AuthorsBooks = new HashSet<AuthorBook>();   
        }
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;


        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string LasttName { get; set; } = null!;


        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Phone { get; set; } = null!;

        public ICollection<AuthorBook> AuthorsBooks { get; set; } = null!;
    }
}
