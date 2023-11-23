using LanchesWeb.Models;

namespace LanchesWeb.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
