using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookCatalog.Model.Entity;
using BookCatalog.Model.Repository;

namespace BookCatalog.Controller
{
    public class BukuController
    {
        private BukuRestApiRepository _repository;

        public BukuController()
        {
            _repository = new BukuRestApiRepository();
        }

        public List<Buku> ReadByJudul(string judulBuku)
        {
            return _repository.ReadByJudul(judulBuku);
        }

        public List<Buku> ReadByPenerbit(string namaPenerbit)
        {
            return _repository.ReadByPenerbit(namaPenerbit);
        }

        public List<Buku> ReadByPengarang(string namaPengarang)
        {
            return _repository.ReadByPengarang(namaPengarang);
        }
    }
}
