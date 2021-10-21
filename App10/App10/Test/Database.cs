using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App10.Test
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Persona>().Wait();
        }

        public Task<List<Persona>> GetPeopleAsync()
        {
            return _database.Table<Persona>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Persona person)
        {
            return _database.InsertAsync(person);
        }
    }
}
