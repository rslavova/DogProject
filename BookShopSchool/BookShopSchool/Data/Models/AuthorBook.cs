using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSchool.Data.Models
{
    public class AuthorBook
    {
        
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;




    }
}
