using MyDropingWords.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDropingWords.ViewModels
{
    public class DictionaryPageVM : ObservableCollection<Word>
    {
        public List<Word> words { get; set; } = null!;
        public DictionaryPageVM() { }
    }
}
