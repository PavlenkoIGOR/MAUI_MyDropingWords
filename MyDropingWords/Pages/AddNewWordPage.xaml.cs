namespace MyDropingWords.Pages;

public partial class AddNewWordPage : ContentPage
{
	public AddNewWordPage()
	{
		InitializeComponent();
	}

	async void AddNewWordToDictionary(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AddNewWordPage());
	}
}