using Microsoft.Maui.Controls.PlatformConfiguration;
using MyDropingWords.Data;
using MyDropingWords.Services.SQLServices;
using System.Reflection;
using System.IO;
using MyDropingWords.ViewModels;

namespace MyDropingWords.Pages;

public partial class DictionaryPage : ContentPage
{
	DBService DBService { get; set; }
	public List<Word> words { get; set; } = null!;
	public DictionaryPageVM dpVM;
	public DictionaryPage(DBService dB, DictionaryPageVM dpVM)
	{
        InitializeComponent();
        BindingContext = this;
        DBService = dB;
		this.dpVM = dpVM;

		//words = new List<Word>() 
		//{
		//	new Word(){ id = 2, word = "stone"},
  //          new Word(){ id = 3, word = "book"},
  //          new Word(){ id = 4, word = "pine"}
  //      };
		BindingContext = this;
    }

	async void GetWordsFromDB(object sender, EventArgs e)
	{
		//List<Word> wordsDto = await DBService.sqliteConnection.Table<Word>().ToListAsync();
		//foreach (var item in wordsDto)
		//{
		//	words.Add(item);
		//}
        dpVM.words = await DBService.sqliteConnection.Table<Word>().ToListAsync();
	}
}


