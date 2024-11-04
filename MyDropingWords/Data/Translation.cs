using SQLite;
using sys = System.ComponentModel.DataAnnotations.Schema;


namespace MyDropingWords.Data;

[Table("Translations")]
public class Translation
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int id { get; set; }

    [Column("translation")]
    public string? translation { get; set; }

    [Column("word_id")]
    public int word_id { get; set; }
}
