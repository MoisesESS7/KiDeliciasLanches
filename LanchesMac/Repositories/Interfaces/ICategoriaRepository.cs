using KiDeliciasLanches.Models;

namespace KiDeliciasLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
