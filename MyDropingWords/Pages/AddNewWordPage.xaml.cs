using MyDropingWords.Services.SQLServices;

namespace MyDropingWords.Pages;

public partial class AddNewWordPage : ContentPage
{
	DBService DBService { get; set; }
    public AddNewWordPage(DBService dB)
	{
		InitializeComponent();
		DBService = dB;
	}

	async void AddNewWordToDictionary(object sender, EventArgs e)
	{
		//await 
	}
}