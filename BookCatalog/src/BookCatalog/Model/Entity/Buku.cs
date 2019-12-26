using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Model.Entity
{
    public class Buku
    {        
        public string Isbn { get; set; }
        public string Judul { get; set; }
        public int Stok { get; set; }
        public string Penerbit { get; set; }
        public string Pengarang { get; set; }
    }
}
