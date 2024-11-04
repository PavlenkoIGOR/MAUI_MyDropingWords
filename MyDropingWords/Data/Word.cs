using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDropingWords.Data
{
    [Table("Words")]
    public class Word
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int id { get; set; }

        [Column("word")]
        public string word { get; set; } = null!;
    }
}
