using LanchesWeb.Data;
using LanchesWeb.Models;

namespace LanchesWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LanchesWebContext Context;


        public CategoriaRepository(LanchesWebContext context)
        {
            Context = context;
        }
        public IEnumerable<Categoria> Categorias => Context.Categorias;
        
    }
}
