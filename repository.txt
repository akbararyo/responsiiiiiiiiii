using BookCatalog.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace BookCatalog.Model.Repository
{
    public class BukuRestApiRepository
    {
        /// <summary>
        /// Method untuk pencarian data buku berdasarkan judul
        /// </summary>
        /// <param name="judulBuku"></param>
        /// <returns></returns>
        public List<Buku> ReadByJudul(string judulBuku)
        {
            string baseUrl = "http://responsi.buatdevelop.com:5000/";
            string endpoint = "api/buku?opsi=judul&&keyword=" + judulBuku;

            //objek rest client
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            var response = client.Execute<List<Buku>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data buku berdasarkan nama penerbit
        /// </summary>
        /// <param name="namaPenerbit"></param>
        /// <returns></returns>
        public List<Buku> ReadByPenerbit(string namaPenerbit)
        {
            string baseUrl = "http://responsi.buatdevelop.com:5000/";
            string endpoint = "api/buku?opsi=penerbit&&keyword=" + namaPenerbit;

            //objek rest client
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            var response = client.Execute<List<Buku>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data buku berdasarkan nama pengarang
        /// </summary>
        /// <param name="namaPengarang"></param>
        /// <returns></returns>
        public List<Buku> ReadByPengarang(string namaPengarang)
        {
            string baseUrl = "http://responsi.buatdevelop.com:5000/";
            string endpoint = "api/buku?opsi=pengarang&&keyword=" + namaPengarang;

            //objek rest client
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            var response = client.Execute<List<Buku>>(request);

            return response.Data;
        }
    }
}
