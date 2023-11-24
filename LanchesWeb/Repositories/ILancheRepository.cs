using LanchesWeb.Models;

namespace LanchesWeb.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches();
        IEnumerable<Lanche> LanchesPreferidos();
        Lanche GetLancheById(int lancheId);
    }
}
