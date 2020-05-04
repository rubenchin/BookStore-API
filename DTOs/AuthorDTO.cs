using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    public class AuthorDTO
    {
        public int id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public virtual IList<BookDTO> Books { get; set; }
    }
}
