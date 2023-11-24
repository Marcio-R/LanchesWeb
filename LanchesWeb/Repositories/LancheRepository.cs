using LanchesWeb.Data;
using LanchesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesWeb.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly LanchesWebContext Context;

        public LancheRepository(LanchesWebContext context)
        {
            Context = context;
        }

        public IEnumerable<Lanche> Lanches() 
        {
           return Context.Lanches.Include(c => c.Categoria).ToList();
        }

        public IEnumerable<Lanche> LanchesPreferidos() 
        {
            return Context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);
        } 

        public Lanche GetLancheById(int lancheId)
        {
            var lanche = Context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return lanche;
        }
    }
}
