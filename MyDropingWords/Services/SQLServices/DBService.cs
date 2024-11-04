using MyDropingWords.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDropingWords.Services.SQLServices
{
    public class DBService
    {
        internal Constants conn;
        internal SQLiteAsyncConnection sqliteConnection;
        internal SQLiteAsyncConnection DataBase => (sqliteConnection ??= new SQLiteAsyncConnection(DbPath, Constants.Flags));
        //public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.DBName);
        public static string DbPath { get; } = Path.Combine(FileSystem.AppDataDirectory, Constants.DBName);
        public DBService()
        {
            conn = new Constants();
            DataBase.CreateTableAsync<Word>();
            DataBase.CreateTableAsync<Translation>();
        }
        
        public async Task<List<Word>> GetWords()
        {
            
            return await sqliteConnection.Table<Word>().ToListAsync();
        }
    }
}
