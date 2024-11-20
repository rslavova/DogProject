using BookShopSchool.Data.Models.Enum;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSchool.Data.Models
{
    public class Book
    {
        public Book()
        {
            this.AuthorsBooks = new HashSet<AuthorBook>();
        }
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        public Genre Genre { get; set; }

        [Range(typeof(decimal),"0.01","798999999")]
        public decimal Price { get; set; }

        [Range(50,5000)]
        public int Pages { get; set; }

        [Required]
        public DateTime PublishedOn { get; set; }
        public ICollection<AuthorBook> AuthorsBooks { get; set; } = null!;
    }
}
