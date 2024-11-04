using MyDropingWords.Data;
using MyDropingWords.Services.SQLServices;
using SQLite;

namespace MyDropingWords
{
    public partial class App : Application
    {
        DBService _dBService;
        //public App(MainPage mainPage)
        //{
        //    InitializeComponent();  
        //    MainPage = new NavigationPage(mainPage);
        //}

        public App(MainPage mainPage, DBService dB)
        {
            InitializeComponent();
            _dBService = dB;
            MainPage = new NavigationPage(mainPage);
        }
    }
}
