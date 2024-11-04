using MyDropingWords.Pages;
using MyDropingWords.Services.SQLServices;
using MyDropingWords.ViewModels;

namespace MyDropingWords;

public partial class MainPage : ContentPage
{
    DBService DBService;
    public DictionaryPageVM dpVM {  get; set; }
    public MainPage(DBService dB, DictionaryPageVM dpVM)
    { 
        InitializeComponent();
        BindingContext = this;
        DBService = dB;
        this.dpVM = dpVM;
    }

    
    private void OnExitClicked(object sender, EventArgs e)
    { 

    }

    private async void ToAddNewWordPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddNewWordPage(DBService));
    }
    private async void ToDictionaryPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DictionaryPage(DBService, dpVM));
    }
}
