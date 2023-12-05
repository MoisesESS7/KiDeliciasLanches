using KiDeliciasLanches.Context;
using KiDeliciasLanches.Models;
using KiDeliciasLanches.Repositories.Interfaces;

namespace KiDeliciasLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public IEnumerable<Categoria> Categorias => _context.Categorias;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
