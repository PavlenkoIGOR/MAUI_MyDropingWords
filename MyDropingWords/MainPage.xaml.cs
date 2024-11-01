using MyDropingWords.Pages;

namespace MyDropingWords;

public partial class MainPage : ContentPage
{
    public MainPage()
    { 
        InitializeComponent();
        BindingContext = this;
    }

    
    private void OnExitClicked(object sender, EventArgs e)
    { 

    }

    private async void ToAddNewWordPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddNewWordPage());
    }
}
