using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RakutenAPI_App33
{
    public partial class MainPage : ContentPage
    {
        List<RakutenModel> Rakuten_List;
        ObservableCollection<RakutenModel> users = new ObservableCollection<RakutenModel>();

        public MainPage()
        {
            InitializeComponent();
            UserListView.ItemsSource = users;

            getData(new WebData());

            users.Add(new RakutenModel { booksGenreId = Rakuten_List[0].booksGenreId });
            users.Add(new RakutenModel { booksGenreName = Rakuten_List[0].booksGenreName });
            users.Add(new RakutenModel { genreLevel = Rakuten_List[0].genreLevel });



        }


        async void getData(WebData webDS)
        {
            try
            {
                Rakuten_List = await webDS.AsyncGetWebData();
            }
            catch(System.Exception ex)
            {
                await DisplayAlert("error", ex.Message.ToString(), "OK");
            }
        }
    }
}
