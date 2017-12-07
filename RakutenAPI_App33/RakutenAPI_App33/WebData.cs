using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace RakutenAPI_App33
{
    public class WebData : ContentPage
    {
        public List<RakutenModel> RakutenList;

        public string Rakuten_URL = "https://app.rakuten.co.jp/services/api/BooksTotal/Search/20170404?format=json&isbn=|&booksGenreId=001&applicationId=1008026300680682252";

        public async Task<List<RakutenModel>> AsyncGetWebData()
        {

            //ISBNコード入力
            var isbncode = ;


            RakutenList = new List<RakutenModel>();

            HttpClient httpClient = new HttpClient();

            Task<string> stringAsync = httpClient.GetStringAsync(Rakuten_URL);

            string result = await stringAsync;

            RakutenList = JsonConvert.DeserializeObject<List<RakutenModel>>(result);

            return RakutenList;

        }
    }
}