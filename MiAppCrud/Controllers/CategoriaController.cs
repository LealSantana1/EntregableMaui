using System.IO;
using MiAppCrud.Models;
using Microsoft.Maui.Controls;

public class CategoriaController
{
    private readonly CategoriaService _categoriaService;

    public CategoriaController()
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "categoria.db3");
        _categoriaService = new CategoriaService(dbPath);
    }

    public async Task<List<Categoria>> GetAllCategorias()
    {
        return await _categoriaService.GetAll();
    }

    public async void AddCategoria(Categoria categoria)
    {
        await _categoriaService.Add(categoria);
    }

    public async void UpdateCategoria(Categoria categoria)
    {
        await _categoriaService.Update(categoria);
    }

    public async void DeleteCategoria(int id)
    {
        await _categoriaService.Delete(id);
    }
}
