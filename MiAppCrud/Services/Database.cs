using SQLite;
using MiAppCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Database
{
    private SQLiteAsyncConnection _database;

    public Database(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Categoria>().Wait();
    }

    public Task<List<Categoria>> GetAllCategoriasAsync()
    {
        return _database.Table<Categoria>().ToListAsync();
    }

    public Task<Categoria> GetCategoriaAsync(int id)
    {
        return _database.Table<Categoria>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveCategoriaAsync(Categoria categoria)
    {
        if (categoria.Id != 0)
            return _database.UpdateAsync(categoria);
        else
            return _database.InsertAsync(categoria);
    }

    public Task<int> DeleteCategoriaAsync(int id)
    {
        return _database.DeleteAsync<Categoria>(id);
    }
}
